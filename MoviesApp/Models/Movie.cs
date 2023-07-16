﻿using Microsoft.Identity.Client;

namespace MoviesApp.Models
{
    public class Movie
    {
		private int _id;

		public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        private string _title;

		public string Title
		{
			get { return _title; }
			private set { _title = value; }
		}

		private DateTime _releaseDate;
		public DateTime ReleaseDate
        {
            get { return _releaseDate; }
            private set { _releaseDate = value; }
        }

        private string _producer;
		public string Producer
        {
            get { return _producer; }
            private set { _producer = value; }
        }
        private string _genre;
		public string Genre
        {
            get { return _genre; }
            private set { _genre = value; }
        }
        private string _description;
		public string Description
        {
            get { return _description; }
            private set { _description = value; }
        }

        public Movie()
        {
            
        }

        public Movie(string title, string description, string genre, string producer, DateTime releaseDate)
        {
            _title = title;
			_description = description;
			_genre = genre;
			_producer = producer;
			_releaseDate = releaseDate;

        }

		public void UpdateTitle(string newTitle)
		{
			if (_title != newTitle)
			{
				_title = newTitle;
			}

		}

		public void UpdateDescription(string newDescription)
		{
			if (newDescription != _description)
			{
				_description = newDescription;
			}
		}

		public void UpdateProducer(string newProducer)
		{
			if (newProducer != _producer)
			{
				_producer = newProducer;
			}
		}

		public void UpdateGenre(string newGenre)
		{
			if(newGenre != _genre)
			{
				_genre = newGenre;
			}
		}

		public void UpdateReleaseDate(DateTime newReleaseDate)
		{
			if(_releaseDate != newReleaseDate)
			{
				_releaseDate = newReleaseDate;
			}
		}
    }
}
