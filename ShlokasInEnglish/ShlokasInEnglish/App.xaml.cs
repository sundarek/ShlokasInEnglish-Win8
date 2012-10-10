using ShlokasInEnglish.Common;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using ShlokasInEnglish.DataModel;

// The Split App template is documented at http://go.microsoft.com/fwlink/?LinkId=234228

namespace ShlokasInEnglish
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : Application
    {
        // List of Deites and Shlokas
        static internal List<deity> allDeities = new List<deity>();

        /// <summary>
        /// Initializes the singleton Application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;

            deity[] sampleDeities = new deity[9];
            shlokas[] sampleShlokas = new DataModel.shlokas[9];


            string[] allShlokasOrig = new string[9];
            string[] allShlokasEng = new string[9];
            string[] allUrls = new string[9];

            sampleShlokas[0] = new shlokas();
            sampleShlokas[0].ShlokaID = "Shloka1";
            sampleShlokas[0].ShlokaName = "Shloka on Lord Ganesha";
            sampleShlokas[0].ShlokaOriginal = "Vakra Thunda Maha Kayam,\nKoti Soorya Sama prabha,\nNirvignam Kuru me Deva,\nSarva karyeshu sarvadha.";
            sampleShlokas[0].ShlokaEnglish = "He who has an immense body,\nHe who has a broken tusk,\nHe who shines like billions of Suns,\nRemove all hindrances,\nFrom all my work and for all times.";
            allUrls[0] = "http://en.wikipedia.org/wiki/Ganesha";

            sampleShlokas[1] = new shlokas();
            sampleShlokas[1].ShlokaID = "Shloka2";
            sampleShlokas[1].ShlokaName = "Shloka on Lord Shiva";
            sampleShlokas[1].ShlokaOriginal = "Santham padmasanastham sasa dhara makutam panchavakthram trinethram,\nSoolam vajram cha gadgam parasumabhayakam  daksha bhahe vahantham,\nNagam pasam cha gandaam pralayahuthavaham sangusam vama bhage,\nNanalangara deeptham sphatikamani nibham parvatheesam namami.";
            sampleShlokas[1].ShlokaEnglish = "I salute the consort of Goddess Parvathi, \nWho is peaceful, who sits in a lotus pose,\nWho wears the moon on his crown,\nWho has five faces, who has three eyes,\nWho holds  Soola, Vajra, white axe, sword,\nAnd symbol of protection on his right,\nWho holds snake , rope bell, fire of deluge,\nAnd goad on his left side,\nWho shines by his several ornaments,\nAnd who has a luster of the crystal ball.";
            allUrls[1] = "http://en.wikipedia.org/wiki/Shiva";

            sampleShlokas[2] = new shlokas();
            sampleShlokas[2].ShlokaID = "Shloka3";
            sampleShlokas[2].ShlokaName = "Shloka on Goddess Lakshmi";
            sampleShlokas[2].ShlokaOriginal = "Devi Padmasanastha  vipula kateethatee padma pathrayathakshi,\nGambheeraavarthanabhi sthanbharanamitha shubra vasthrothareeya,\nLakshmeer divyair gajendarair mani gana khachithaisnapitha hemakumbhair,\nNithyam saa padmahastha  mama vasathu gruhe  sarva mangalya yuktha";
            sampleShlokas[2].ShlokaEnglish = "Let my house be always occupied by that Lakshmi,\nWho has everything that is good in her,\nWho sits on a lotus, who has a very broad middle,\nWho has eyes similar to the lotus leaf,\nWho has a belly button similar to the deep whirlpool,\nWho is slightly bent due to her heavy breasts.\nWho wears clean cloths, who is being anointed by,\nHoly elephants wearing gem studded ornaments,\nAnd using pots of gold and who keeps in her hand flowers of lotus.";
            allUrls[2] = "http://en.wikipedia.org/wiki/Lakshmi";

            sampleShlokas[3] = new shlokas();
            sampleShlokas[3].ShlokaID = "Shloka4";
            sampleShlokas[3].ShlokaName = "Shloka on Goddess Tripurasundari";
            sampleShlokas[3].ShlokaOriginal = "Balarkayutha thejasam trinayanam rakthamarollasineem,\nNanalangruthirajamana vapusham baloduratchekaram,\nHasthairikshadhanusyanim sumasaram  pasam mudhra bibrathim,\nSri chakra sthitha sundarim trijagathamadara bhootham  smareth.";
            sampleShlokas[3].ShlokaEnglish = "I meditate on her who is the basis of all the three worlds,\nWho shines like the rising sun, who has three eyes, who dresses,\nHerself with cloths of blood red colour, Who shines in a pretty form,\nWhich shines with different ornaments, who wears the crescent on her head,\nWho holds a bow of sugarcane , flower arrow, rope and goad in her four hands,\nAnd who is the pretty goddess who sits on the Sri Chakra.";
            allUrls[3] = "http://en.wikipedia.org/wiki/Tripura_Sundari";

            sampleShlokas[4] = new shlokas();
            sampleShlokas[4].ShlokaID = "Shloka5";
            sampleShlokas[4].ShlokaName = "Shloka on Goddess Durga";
            sampleShlokas[4].ShlokaOriginal = "Ashtou bhujangim mahishasya mardhinim,\nSasankhachakram sara soola dharineem,\nThaam divvy yogim sahajatha vedhasim,\nDurgaam sada saranamaham prapadhye.";
            sampleShlokas[4].ShlokaEnglish = "I always seek the protection of Durga,\nWho has eight hands, who killed Mahisha,\nWho is armed with conch, wheel, bow and spear,\nWho is a great sage  and who was born with Vedas.";
            allUrls[4] = "http://en.wikipedia.org/wiki/Durga";

            sampleShlokas[5] = new shlokas();
            sampleShlokas[5].ShlokaID = "Shloka6";
            sampleShlokas[5].ShlokaName = "Shloka on Goddess Gayathri";
            sampleShlokas[5].ShlokaOriginal = "Muktha vidhruma hema neela davalachayair mukhaistheekshanai,\nRyktha mindu nibadha rathnamakutam bahwatha varnathmikam,\nGayathreem varadabhayangusakasam  shubram kapalam gunam,\nChakram sankhamadharavindayugalam hasthair vahantheem bhaje.";
            sampleShlokas[5].ShlokaEnglish = "I sing about that Gayathri  who has five faces of  the colour of,\nPearl, coral, gold , blue and white, who has three eyes,\nWho has a crown adorned with the crescent of the moon,\nWho has a soul described be several words with several meanings,\nAnd who holds symbol of pardon , symbol of excuse,  goad , axe, skull,\nRope , holy wheel , conch  and two lotuses in her ten hands.";
            allUrls[5] = "http://en.wikipedia.org/wiki/Gayatri";

            sampleShlokas[6] = new shlokas();
            sampleShlokas[6].ShlokaID = "Shloka7";
            sampleShlokas[6].ShlokaName = "Shloka on Lord Hanuman";
            sampleShlokas[6].ShlokaOriginal = "Panchasyachutamaneka vichitra veeryam,\nSri shanka chakra ramaniya bhujagra desam,\nPeethambaram makara kundala noopurangam,\nDhyayethitam kapivaram hruthi bhvayami.";
            sampleShlokas[6].ShlokaEnglish = "I meditate on and keep in my  mind that divine hanuman\nWho has five holy faces, who is a great warrior,\nWho holds the conch and holy wheel in his hands,\nWho wears red silk cloth and wears,\nShark like ear drops and anklets";
            allUrls[6] = "http://en.wikipedia.org/wiki/Hanuman";

            sampleShlokas[7] = new shlokas();
            sampleShlokas[7].ShlokaID = "Shloka8";
            sampleShlokas[7].ShlokaName = "Shloka on Lord Subramanya";
            sampleShlokas[7].ShlokaOriginal = "Dyayeth shanmugamindu koti sadrusam , rathna prabha shobitham,\nBalarkadhyuthi  shad kireeda vilasad keyura haranvitham,\nKarnalambitha kundala  pravilasad  ganda sthalee shobitham,\nKanchi kankana kinkini ravayutham  srungara sarodhayam.";
            sampleShlokas[7].ShlokaEnglish = "Meditate  on that six faced god, who is like billions of moons,\nWho shines with gem studded ornaments, who looks like the baby sun,\nWho shines with six crowns, who wears bracelets and chains,\nWhose hanging ear drops make his cheeks  appear pretty,\nWho wears golden belt, bangles and anklets,\nAnd is the essence of the feeling of romance.";
            allUrls[7] = "http://en.wikipedia.org/wiki/Murugan";

            sampleShlokas[8] = new shlokas();
            sampleShlokas[8].ShlokaID = "Shloka9";
            sampleShlokas[8].ShlokaName = "Shloka on Lord Hayagreeva";
            sampleShlokas[8].ShlokaOriginal = "VyakhyamudrAm kara-sarasijai pustakam Sankha-chakre,\nBibhrad-bhinna-sphatika-ruchire pundarike nishannah,\nAmlana-srir amruta-vishadaih amsubhih plavayan maam,\nAvirbhuyat anagha-mahima mAnase vagadhisah.";
            sampleShlokas[8].ShlokaEnglish = "May my mind be filled with the nectar like,\nCool white rays of that Lord of words,\nWho shows the symbol of  teaching and interpretation by one hand,\nWho holds conch , wheel  and book in his other three hands,\nWho is seated on a white lotus flower which resembles,\nA flower carved out of pure white crystal,\nAnd who is great , brilliant and perennially flawless.";
            allUrls[8] = "http://en.wikipedia.org/wiki/Hayagriva";

            for (int i = 0; i < 9; i++)
            {
                sampleDeities[i] = new deity();
                sampleDeities[i].DeityID = "Deity" + (i + 1);
                sampleDeities[i].DeityName = sampleShlokas[i].ShlokaName.Remove(0, 10);
                sampleDeities[i].DeityImage = "/Assets/LightGray.png";
                sampleDeities[i].ShlokasOfDeity.Add(sampleShlokas[i]);                
            }

            sampleDeities[0].DeityImage = "/Assets/Ganesha2.png";
            sampleDeities[1].DeityImage = "/Assets/Shiva2.png";
            sampleDeities[2].DeityImage = "/Assets/Lakshmi2.png";
            sampleDeities[3].DeityImage = "/Assets/Tripurasundari2.png";
            sampleDeities[4].DeityImage = "/Assets/Durga2.png";
            sampleDeities[5].DeityImage = "/Assets/Gayathri2.png";
            sampleDeities[6].DeityImage = "/Assets/Hanuman2.png";
            sampleDeities[7].DeityImage = "/Assets/Subramanya2.png";
            sampleDeities[8].DeityImage = "/Assets/Hayagreeva2.png";


            allDeities.AddRange(sampleDeities);
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used when the application is launched to open a specific file, to display
        /// search results, and so forth.
        /// </summary>
        /// <param name="args">Details about the launch request and process.</param>
        protected override async void OnLaunched(LaunchActivatedEventArgs args)
        {
            Frame rootFrame = Window.Current.Content as Frame;

            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
            
            if (rootFrame == null)
            {
                // Create a Frame to act as the navigation context and navigate to the first page
                rootFrame = new Frame();
                //Associate the frame with a SuspensionManager key                                
                SuspensionManager.RegisterFrame(rootFrame, "AppFrame");

                if (args.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    // Restore the saved session state only when appropriate
                    try
                    {
                        await SuspensionManager.RestoreAsync();
                    }
                    catch (SuspensionManagerException)
                    {
                        //Something went wrong restoring state.
                        //Assume there is no state and continue
                    }
                }

                // Place the frame in the current Window
                Window.Current.Content = rootFrame;
            }
            if (rootFrame.Content == null)
            {
                // When the navigation stack isn't restored navigate to the first page,
                // configuring the new page by passing required information as a navigation
                // parameter
                if (!rootFrame.Navigate(typeof(ItemsPage), "AllGroups"))
                {
                    throw new Exception("Failed to create initial page");
                }
            }
            // Ensure the current window is active
            Window.Current.Activate();
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private async void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            await SuspensionManager.SaveAsync();
            deferral.Complete();
        }
    }
}
