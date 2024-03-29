﻿using NewsApi.Models;

namespace NewsApi.Services
{
    public class AnnouncementCollectionService : IAnnouncementCollectionService
    {
        private List<Announcement> _announcements = new List<Announcement> { new Announcement { Id = Guid.NewGuid(), CategoryId = "1", Title = "First Announcement", Description = "First Announcement Description" , Author = "Author_1"},
        new Announcement { Id = Guid.NewGuid(), CategoryId = "1", Title = "Second Announcement", Description = "Second Announcement Description", Author = "Author_1" },
        new Announcement { Id = Guid.NewGuid(), CategoryId = "1", Title = "Third Announcement", Description = "Third Announcement Description", Author = "Author_2"  },
        new Announcement { Id = Guid.NewGuid(), CategoryId = "1", Title = "Fourth Announcement", Description = "Fourth Announcement Description", Author = "Author_3"  },
        new Announcement { Id = Guid.NewGuid(), CategoryId = "1", Title = "Fifth Announcement", Description = "Fifth Announcement Description", Author = "Author_4"  }
        };

        public bool Create(Announcement model)
        {
            _announcements.Add(model);
            return true;
        }

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Announcement Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Announcement> GetAll()
        {
            return _announcements;
        }

        public List<Announcement> GetAnnouncementsByCategoryId(string categoryId)
        {
            throw new NotImplementedException();
        }

        public bool Update(Guid id, Announcement model)
        {
            throw new NotImplementedException();
        }
    }
}