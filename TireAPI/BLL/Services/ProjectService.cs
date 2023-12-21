using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOs;
using DAL.EF.Models;
using DAL.Repos;
using AutoMapper;

namespace BLL.Services
{
    public class ProjectService
    {
        public static List<MemberDTO> GetAllMember()
        {
            var data = MemberRepo.GetAllMember();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Member, MemberDTO>();
            });
            var mapper = new Mapper(config);
            var convertedd = mapper.Map<List<MemberDTO>>(data);
            return convertedd;
        }
        public static bool createMember(MemberDTO m)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Member, MemberDTO>();
            });
            var mapper = new Mapper(config);
            var convertedd = mapper.Map<Member>(m);
            var res = MemberRepo.Create(convertedd);
            return res;

        }

    }
}
