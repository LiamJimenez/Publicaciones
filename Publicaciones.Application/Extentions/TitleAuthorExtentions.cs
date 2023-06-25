using Publicaciones.Application.Dtos.titleauthor;
using Publicaciones.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Publicaciones.Application.Extentions
{
    public static class TitleAuthorExtentions
    {
        public static titleauthor ConvertDtoAddToEntity(this TitleAuthorAddDto titleAuthorAddDto)
        {
            return new titleauthor()
            {
                au_id = titleAuthorAddDto.au_id,
                title_id = titleAuthorAddDto.title_id,
                au_ord = titleAuthorAddDto.au_ord,
                royaltyper = titleAuthorAddDto.royaltyper,
                

            };
        }

        public static titleauthor ConvertDtoUpdateToEntity(this titleAuthorUpdateDto titleAuthorsUpdatedto)
        {
            return new titleauthor()
            {
                au_id = titleAuthorsUpdatedto.au_id,
                title_id = titleAuthorsUpdatedto.title_id,
                au_ord = titleAuthorsUpdatedto.au_ord,
                royaltyper = titleAuthorsUpdatedto.royaltyper
                

            };
        }

    }
}