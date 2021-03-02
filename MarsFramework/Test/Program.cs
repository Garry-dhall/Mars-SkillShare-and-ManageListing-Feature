using MarsFramework.Pages;
using NUnit.Framework;


namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {

            [Test]
            public void Test()
            {
                //ShareSkill obj = new ShareSkill();
                //obj.EnterShareSkill();
                ManageListings Obj2 = new ManageListings();
                  Obj2.Viewlistings();
                  //Obj2.EditListing();
                  //Obj2.DeleteListing();
            }



        }
    }
}

