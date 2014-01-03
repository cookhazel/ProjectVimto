namespace ClassesSE
{
    public partial class Staff
        // Staff inherits from Object, has a virtual member ToString() that has been overriden below (polymorphism)
    {
        public override string ToString()
        {
            string title = "Nurse.";
            if (this._IsGP.ToLower().StartsWith("yes"))
                title = "Dr.";

            return string.Format("{0} {1}", title, this.firstName);
            // returns to ToString the dr/nurses name in this format.
            //The drop down box calls this method.
        }
    }
}