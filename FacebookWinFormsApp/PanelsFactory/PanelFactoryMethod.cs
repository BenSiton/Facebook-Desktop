using System.Windows.Forms;

namespace FacebookApp.PanelsFactory
{
    public static class PanelFactoryMethod
    {
        public static PanelCustom Create(Form i_Form)
        {
            PanelCustom formToCreate;
            if(i_Form is FormMain)
            {
                formToCreate = new PanelCustomFull();
            }
            else if(i_Form is FormMostInCommon)
            {
                formToCreate = new PanelNGB();
            }
            else
            {
                formToCreate = new PanelCustom();
            }

            return formToCreate;
        }
    }
}
