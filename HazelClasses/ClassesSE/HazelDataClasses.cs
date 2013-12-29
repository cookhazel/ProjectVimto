namespace ClassesSE
{
    public partial class Staff
    {
        public override string ToString()
        {
            string title = "Nurse.";
            if (this._IsGP.ToLower().StartsWith("yes"))
                title = "Dr.";

            return string.Format("{0} {1}", title, this.firstName);
        }
    }
}