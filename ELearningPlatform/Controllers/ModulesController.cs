﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ELearningPlatform.Models;
using ELearningPlatform.Data;

namespace ELearningPlatform.Controllers
{
    public class ModulesController : Controller
    {
        private readonly ELearningPlatformContext _context;
        private readonly CoursesData _coursesData;
        private readonly UsersData _usersData;
        private readonly ModuleData _moduleData;

        public ModulesController(ELearningPlatformContext context)
        {
            _context = context;
            _coursesData = new CoursesData(_context);
            _usersData = new UsersData(_context);
            _moduleData = new ModuleData(_context);
        }
        public IActionResult Index()
        {
            return View();
        }

        [Route("ModuleDetails")]
        [HttpGet]
        public IActionResult DetailsModule(int id)
        {
            User user = SessionHelper.Get<User>(HttpContext.Session, SessionHelper.SessionKeyUser);
            List<Content> contents = _moduleData.GetContents(id);
            TempData[TempDataHelper.TempdataKeyContents] = contents;
            TempData[TempDataHelper.TempdataKeyModule] = _moduleData.GetModule(id);
            TempData[TempDataHelper.TempdataKeyModuleInstructor] = _moduleData.GetInstructor(id);
            if(user != null)
                TempData[TempDataHelper.TempdataKeyModuleIsFinished] = _moduleData.isFinished(id, user.Id);
            return View("ModuleDetails");
        }
    }
}