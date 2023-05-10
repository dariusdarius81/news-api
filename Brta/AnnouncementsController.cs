using Microsoft.AspNetCore.Mvc;
using NewsApi.Models;
using NewsApi.Services;

namespace NewsApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncementsController : ControllerBase
    {
        private IAnnouncementCollectionService _announcementCollectionService;

        /// <summary>
        /// this is a get function
        /// </summary>
        /// <returns></returns>

        public AnnouncementsController(IAnnouncementCollectionService announcementCollectionService)
        {
            _announcementCollectionService = announcementCollectionService ?? throw new ArgumentNullException(nameof(AnnouncementCollectionService));
        }

        [HttpPost]
        public IActionResult Create([FromBody] Announcement announcement)
        {
            if (announcement == null)
            {
                return BadRequest("Announcement cannot be null");
            }

            _announcementCollectionService.Create(announcement);

            List<Announcement> announcements = _announcementCollectionService.GetAll();
            return Ok(announcements);
        }

        //[HttpDelete("{id}")]
        //public IActionResult Delete([FromRoute] Guid id)
        //{
        //    int numOfElementsDeleted = _announcements.RemoveAll(item => item.Id == id);
        //    if (numOfElementsDeleted == 0)
        //    {
        //        return NotFound("Announcement cannot be deleted!");
        //    }

        //    return Ok("Announcement was deleted!");
        //}

        [HttpGet]
        public IActionResult GetAnnouncements()
        {
            List<Announcement> announcements = _announcementCollectionService.GetAll();
            return Ok(announcements);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            return Ok("Mesaj");
        }

        //[HttpPut]
        //public IActionResult Put([FromBody] Announcement announcement)
        //{
        //    //return Ok("postat");

        //    Announcement announcementToUpdate = _announcements.FirstOrDefault(item => item.Id == announcement.Id);
        //    if (announcementToUpdate == null)
        //    {
        //        _announcements.Add(announcement);
        //    }
        //    else
        //    {
        //        announcementToUpdate.Title = announcement.Title;
        //        announcementToUpdate.Author = announcement.Author;
        //        announcementToUpdate.Description = announcement.Description;
        //        announcementToUpdate.CategoryId = announcement.CategoryId;
        //    }
        //    return Ok(_announcements);
        //}

        /// <summary>
        /// GetById
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <summary>
        ///
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>

        /// <summary>
        /// Posting
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        /// <summary>
        /// this is a delete function
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //}
    }
}