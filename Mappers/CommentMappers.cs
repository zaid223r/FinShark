using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using api.Dtos.Comment;
using api.Models;
using Microsoft.AspNetCore.Components.Web;

namespace api.Mappers
{
    public static class CommentMappers
    {
        public static CommentDto ToCommentDto(this Comment commentDto)
        {
            return new CommentDto
            {
                Id = commentDto.Id,
                Title = commentDto.Title,
                Content = commentDto.Content,
                CreatedOn = commentDto.CreatedOn,
                StockId = commentDto.StockId
            };
        }

        public static Comment ToCommentFromCreateDto(this CreateCommentRequestDto commentDto, int stockId)
        {
            return new Comment
            {
                Title = commentDto.Title,
                Content = commentDto.Content,
                StockId = stockId
            };
        }
    }
}