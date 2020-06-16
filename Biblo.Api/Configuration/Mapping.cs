using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Biblo.Api.Dto.Get;
using Biblo.DataLayer.Entities;

namespace Biblo.Api.Configuration
{
    public class Mapping
    {
        public static void Configure() => Mapper.Initialize(config =>
        {
            config.CreateMap<Address, AddressDTO>().ReverseMap();
            config.CreateMap<Author, AuthorDTO>().ReverseMap();
            config.CreateMap<Book, BookDTO>().ReverseMap();
            config.CreateMap<BoardMessage, BoardMesssageDTO>().ReverseMap();
            config.CreateMap<CommentBoard, CommentBoardDTO>().ReverseMap();
            config.CreateMap<Inserting, InsertingDTO>().ReverseMap();
            config.CreateMap<PrivateMessage, PrivateMessageDTO>().ReverseMap();
            config.CreateMap<PrivateChat, PrivateChatDTO>().ReverseMap();
            config.CreateMap<User, UserDTO>().ReverseMap();
        });
    }
}
