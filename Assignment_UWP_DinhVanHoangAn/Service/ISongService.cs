﻿using Assignment_UWP_DinhVanHoangAn.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_UWP_DinhVanHoangAn.Service
{
    interface ISongService
    {
        Song CreateSong(MemberCredential memberCredential,Song song);
        List<Song> GetAllSong(MemberCredential memberCredential);
        List<Song> GetMineSongs(MemberCredential memberCredential);
    }
}
