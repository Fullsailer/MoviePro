using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MoviePro.Services
{
    public interface IImageService
    {
        //encode an image from an upload control
        Task<byte[]> EncodePosterAsync(IFormFile poster);

        //encode an image from an url
        Task<byte[]> EncodeImageURLAsync(string imageURL);

        string DecodePoster(byte[] poster, string contentType);

        string RecordConentType(IFormFile poster);


    }
}
