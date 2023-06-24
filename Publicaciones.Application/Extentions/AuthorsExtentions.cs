using Publicaciones.Application.Dtos.Authors;
using Publicaciones.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Publicaciones.Application.Extentions
{
    public static class AuthorsExtentions
    {
        public static Authors ConvertDtoAddToEntity(this AuthorsAddDto authorsAddDto)
        {
            return new Authors()
            {
                city = authorsAddDto.city,
                au_id = authorsAddDto.au_id,
                au_fname = authorsAddDto.au_fname,
                au_lname = authorsAddDto.au_lname,
                zip = authorsAddDto.zip,
                contract = authorsAddDto.contract,
                phone = authorsAddDto.phone,
                state = authorsAddDto.state,
                modifydate = authorsAddDto.ChangeDate,
                creationdate = authorsAddDto.ChangeDate,
                creationuser = authorsAddDto.ChangeUser

            };
        }

        public static Authors ConvertDtoUpdateToEntity(this AuthorsUpdateDto authorsUpdateDto)
        {
            return new Authors()
            {
                city = authorsUpdateDto.city,
                au_id = authorsUpdateDto.au_id,
                au_fname = authorsUpdateDto.au_fname,
                au_lname = authorsUpdateDto.au_lname,
                zip = authorsUpdateDto.zip,
                contract = authorsUpdateDto.contract,
                phone = authorsUpdateDto.phone,
                state = authorsUpdateDto.state,
                modifydate = authorsUpdateDto.ChangeDate,
                creationdate = authorsUpdateDto.ChangeDate,
                creationuser = authorsUpdateDto.ChangeUser

            };
        }

    }
    }
