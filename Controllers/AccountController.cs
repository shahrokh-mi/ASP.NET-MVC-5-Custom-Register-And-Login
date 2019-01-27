using System;
using System.Linq;
using System.Web.Mvc;
using ProjectName.Models;
using ProjectName.ViewModels;

namespace ProjectName : Controller
{
    private User _currentUser;
    private DataBaseEntities db = new DataBaseEntities();

    public ActionResult Register()
    {
        _currentUser = (User)Session["CurrentUser"];
        if (_currentUser != null)       //Check To See If There is already a User Logged In
        {
            return RedirectToAction("Index");
        }
        
        return View();
    }

    public ActionResult Login()
    {
        _currentUser = (User)Session["CurrentUser"];
        if (_currentUser != null)
        {
            return RedirectToAction("Index");
        }
        
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Register(RegisterViewModel model)
    {
        _currentUser = (User)Session["CurrentUser"];
        if (_currentUser != null)
        {
            return RedirectToAction("Index");
        }
        
        if (!ModelState.IsValid)
        {
            return View(model);
        }
        
        _currentUser = new User();
        _currentUser.Username = model.Username;
        _currentUser.Password = model.Password;
        _currentUser.FirstName = model.FirstName;
        _currentUser.LastName = model.LastName
        _currentUser.RegisterDate = System.DateTime.Now;
        db.Users.Add(_currentUser);
        db.SaveChanges();
        Session.Add("CurrentUser", _currentUser);
        return RedirectToAction("Index");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Login(LoginViewModel model)
    {
        _currentUser = (User)Session["CurrentUser"];
        if (_currentUser != null)
        {
            return RedirectToAction("Index");
        }
        
        if (ModelState.IsValid)
        {
            //Check the Database to find a user that matches this username and password
            _currentUser = db.Users.SingleOrDefault(u => u.Username == model.Username && u.Password == model.Password); 
            if (_currentUser != null)
            {
                Session.Add("CurrentUser", _currentUser);
                return RedirectToAction("Index");
            }
            
            ModelState.AddModelError("", "Username or Password is wrong");
        }

        return View(model);
    }

}