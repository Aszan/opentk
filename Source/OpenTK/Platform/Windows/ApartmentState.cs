namespace System.Threading
{

    [Serializable]
    [System.Runtime.InteropServices.ComVisible(true)]
    public enum ApartmentState
    {
        /*=========================================================================
        ** Constants for thread apartment states.
        =========================================================================*/
        STA = 0,
        MTA = 1,
        Unknown = 2
    }

    public static class ThreadExtensions
    {
        public static void SetApartmentState(this Thread t, ApartmentState state)
        {

        }
    }
}