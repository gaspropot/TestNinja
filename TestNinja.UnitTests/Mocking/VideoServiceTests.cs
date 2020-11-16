﻿using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    class VideoServiceTests
    {
        private VideoService _videoService;
        private Mock<IFileReader> _fileReader;
        private Mock<IVideoRepository> _repository;

        [SetUp]
        public void SetUp()
        {
            _fileReader = new Mock<IFileReader>();
            _repository = new Mock<IVideoRepository>();
            _videoService = new VideoService(_fileReader.Object, _repository.Object);
        }

        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
            _fileReader.Setup(fr => fr.Read("video.txt")).Returns("");

            var result = _videoService.ReadVideoTitle();

            Assert.That(result, Does.Contain("error").IgnoreCase);
        }

        [Test]
        public void GetUnprocessedVideosAsCsv_UnprocessedVideosListEmpty_ReturnEmptyString()
        {
            _repository.Setup(r => r.GetUnprocessedVideos()).Returns(new List<Video>());

            var result = _videoService.GetUnprocessedVideosAsCsv();

            Assert.That(result, Is.EqualTo(string.Empty));
        }

        [Test]
        public void GetUnprocessedVideosAsCsv_UnprocessedVideosExist_ReturnStringWithUnprocessedVideoIds()
        {
            var videos = new List<Video>()
            {
                new Video { Id = 1 },
                new Video { Id = 2 },
                new Video { Id = 3 }
            };

            _repository.Setup(r => r.GetUnprocessedVideos()).Returns(videos);

            var result = _videoService.GetUnprocessedVideosAsCsv();

            Assert.That(result, Is.EqualTo("1,2,3"));
        }
    }
}
