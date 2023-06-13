using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using AssetBackedSecurity.Models;

namespace AssetBackedSecurity.Controllers
{
    public class AssetBackedSecurityController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        // GET: ABS
        [HttpGet]
        public ActionResult Index(int i)
        {
           

            // Check user role and perform appropriate actions
            string role = GetUserRole(); // Get the role of the current user
            if (role == "Case Officer")
            {
                // Case Officer can only view records
                return View(GetAllABS());
            }
            else
            {
                // Manager and Administrator can add, update, and delete records
                return View(GetAllABS());
            }
        }

        // GET: ABS/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            // Check user role and perform appropriate actions
            string role = GetUserRole(); // Get the role of the current user
            if (role == "Case Officer")
            {
                // Case Officer can only view records
                AssetBackedSecurity.Models.AssetBackedSecurity abs = GetABSById(id);
                if (abs == null)
                {
                    return NotFound();
                }
                return View(abs);
            }
            else
            {
                // Manager and Administrator can add, update, and delete records
                AssetBackedSecurity.Models.AssetBackedSecurity abs = GetABSById(id);
                if (abs == null)
                {
                    return NotFound();
                }
                return View(abs);
            }
        }

        // GET: ABS/Create
        [HttpGet]
        public ActionResult Create()
        {
            // Check user role and perform appropriate actions
            string role = GetUserRole(); // Get the role of the current user
            if (role == "Administrator" || role == "Manager")
            {
                return View();
            }
            else
            {
                // Case Officer is not allowed to create records
                return RedirectToAction("Index");
            }
        }

        // POST: ABS/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AssetBackedSecurity.Models.AssetBackedSecurity abs)
        {
            // Check user role and perform appropriate actions
            string role = GetUserRole(); // Get the role of the current user
            if (role == "Administrator" || role == "Manager")
            {
                if (ModelState.IsValid)
                {
                    // Add the ABS record
                    AddABS(abs);
                    return RedirectToAction("Index");
                }
                return View(abs);
            }
            else
            {
                // Case Officer is not allowed to create records
                return RedirectToAction("Index");
            }
        }

        // GET: ABS/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            // Check user role and perform appropriate actions
            string role = GetUserRole(); // Get the role of the current user
            if (role == "Administrator" || role == "Manager")
            {
                AssetBackedSecurity.Models.AssetBackedSecurity abs = GetABSById(id);
                if (abs == null)
                {
                    return NotFound();
                }
                return View(abs);
            }
            else
            {
                // Case Officer is not allowed to edit records
                return RedirectToAction("Index");
            }
        }

        // POST: ABS/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, AssetBackedSecurity.Models.AssetBackedSecurity abs)
        {
            // Check user role and perform appropriate actions
            string role = GetUserRole(); // Get the role of the current user
            if (role == "Administrator" || role == "Manager")
            {
                if (ModelState.IsValid)
                {
                    // Update the ABS record
                    UpdateABS(id, abs);
                    return RedirectToAction("Index");
                }
                return View(abs);
            }
            else
            {
                // Case Officer is not allowed to edit records
                return RedirectToAction("Index");
            }
        }

        // GET: ABS/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            // Check user role and perform appropriate actions
            string role = GetUserRole(); // Get the role of the current user
            if (role == "Administrator")
            {
                AssetBackedSecurity.Models.AssetBackedSecurity abs = GetABSById(id);
                if (abs == null)
                {
                    return NotFound();
                }
                return View(abs);
            }
            else
            {
                // Only Administrator can delete records
                return RedirectToAction("Index");
            }
        }

        // POST: ABS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            // Check user role and perform appropriate actions
            string role = GetUserRole(); // Get the role of the current user
            if (role == "Administrator")
            {
                // Delete the ABS record
                DeleteABS(id);
                return RedirectToAction("Index");
            }
            else
            {
                // Only Administrator can delete records
                return RedirectToAction("Index");
            }
        }

        // Helper methods

        // Get the role of the current user (Replace with actual implementation)
        private string GetUserRole()
        {
            // Replace with actual implementation to get the role of the current user
            return "Manager";
        }

        // Get all ABS records (Replace with actual implementation)
        private List<AssetBackedSecurity.Models.AssetBackedSecurity> GetAllABS()
        {
            // Replace with actual implementation to get all ABS records
            List<AssetBackedSecurity.Models.AssetBackedSecurity> absList = new List<AssetBackedSecurity.Models.AssetBackedSecurity>();
            // Add code to populate the absList with data
            // Ensure that the absList is not null before returning the view
            //return View(absList);

            //return new List<ABS>();
            return absList;
        }

        // Get ABS record by ID (Replace with actual implementation)
        private AssetBackedSecurity.Models.AssetBackedSecurity GetABSById(int id)
        {
            // Replace with actual implementation to get the ABS record by ID
            return null;
        }

        // Add ABS record (Replace with actual implementation)
        private void AddABS(AssetBackedSecurity.Models.AssetBackedSecurity abs)
        {
            // Replace with actual implementation to add the ABS record
        }

        // Update ABS record (Replace with actual implementation)
        private void UpdateABS(int id, AssetBackedSecurity.Models.AssetBackedSecurity abs)
        {
            // Replace with actual implementation to update the ABS record
        }

        // Delete ABS record (Replace with actual implementation)
        private void DeleteABS(int id)
        {
            // Replace with actual implementation to delete the ABS record
        }
    }
}