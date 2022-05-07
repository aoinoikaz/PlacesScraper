using Places;
using System;
using System.Windows.Forms;

namespace AddressScraper
{
    public partial class AddressScraperForm : Form
    {
        public AddressScraperForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// This function is the bridge between the GUI and the back end API. It passes in user input
        /// and then makes calls to the back end.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="state"></param>
        private async void Scrape(string input, string state)
        {
            scrapeBtn.Visible = false;
            progressBar.Visible = true;

            Page page = null;
            bool complete = false;
            int pageNumber = 0;

            do
            {
                pageNumber++;

                // If a place api call has already been made
                if (page != null)
                {
                    // More results? If this isn't null there's more pages of data
                    if (!string.IsNullOrEmpty(page.Next))
                    {
                        // get next page
                        page = await PlacesAPI.GetNextPlacesPageByState(page.Next);
                    }
                    else
                    {
                        complete = true;
                    }
                }
                else
                {
                    // TODO - get region from drop down (for canada implementation)
                    page = await PlacesAPI.GetPlacesPageByState(input, state);
                }

                if (!page.RequestStatus.Equals(PlacesAPI.ZERO_RESULTS))
                {
                    foreach (Place place in page.Places)
                    {
                        place.Details = await PlacesAPI.GetDetailsByPlaceId(place.PlaceId);

                        Business newBusiness = new Business();
                        newBusiness.Status = place.Details.BusinessStatus;
                        newBusiness.Name = place.Details.Name;
                        newBusiness.PhoneNumber = place.Details.PhoneNumber;
                        newBusiness.FormattedAddress = place.Details.FormattedAddress;
                        newBusiness.WebsiteUrl = place.Details.WebsiteUrl;

                        Global.Businesses.Add(newBusiness);

                        DisplayBusiness(newBusiness);
                    }
                }
                else
                {
                    MessageBox.Show("Zero results returned!");
                    complete = true;
                }
            }
            while (!complete);

            ProgressComplete();
        }


        /// <summary>
        /// This method simply renders businesses data to the results text box for viewing.
        /// </summary>
        /// <param name="business">A business record that has been retrieved from Places API and then
        /// deserialized into a business object.</param>
        public void DisplayBusiness(Business business)
        {
            resultsTextBox.AppendText("Name: " + business.Name + Environment.NewLine +
                   "Status: " + business.Status + Environment.NewLine +
                   "Formatted Address: " + business.FormattedAddress + Environment.NewLine +
                   "Phone Number: " + business.PhoneNumber + Environment.NewLine +
                   "Website: " + business.WebsiteUrl + Environment.NewLine + Environment.NewLine);
        }


        /// <summary>
        /// This method is called automatically when a query has completed and updates some 
        /// user interface state
        /// </summary>
        public void ProgressComplete()
        {
            scrapeBtn.Visible = true;
            progressBar.Visible = false;


            MessageBox.Show("Total business records: " + Global.Businesses.Count);
        }


       /// <summary>
       /// This method is clicked automatically when the scrape button is clicked. It does some basic validation
       /// and then triggers the internal scraping functionality.
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void OnScrapeButtonClicked(object sender, EventArgs e)
        {
            string input = keywordTextBox.Text;
            object state = stateDropdown.SelectedItem;

            if (!string.IsNullOrEmpty(input))
            {
                if (state != null && !string.IsNullOrEmpty(state.ToString()))
                {
                    Scrape(input, state.ToString());
                }
                else 
                {
                    MessageBox.Show("Must choose a state from the drop down!");
                }
            }
            else
            {
                MessageBox.Show("Input cannot be blank!");
            }
        }


        /// <summary>
        /// This method is called automatically when the dropdown values change.
        /// It handles state of both dropdowns ensuring that the state dropdown only appears
        /// when delivery mode is set to state, and then disappears when set to global.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox deliveryDropdown = (ComboBox)sender;

            if ((string)deliveryDropdown.SelectedItem == "By State")
            {
                stateDropdown.Visible = true;
                stateLabel.Visible = true;

            }
            else
            {
                stateDropdown.Visible = false;
                stateLabel.Visible = false;
            }
        }


        /// <summary>
        /// This method is called automatically when the form loads and simply initializes the system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddressScraperForm_Load(object sender, EventArgs e)
        {
            string apiKey = Config.GetApiKey();

            if (string.IsNullOrEmpty(apiKey))
            {
                MessageBox.Show("Error with api key - application terminating!");

                Application.Exit();
            }

            MessageBox.Show("Loaded API Key");

            PlacesAPI.Init(apiKey);
        }
    }
}
