﻿using Assignment_UWP_DinhVanHoangAn.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_UWP_DinhVanHoangAn.Service
{
    class GoogleDriveFileService: IFileService
    {
        public Task<bool> SaveMemberCredentialToFile(MemberCredential memberCredential)
        {
            throw new NotImplementedException();
        }

        public Task<MemberCredential> ReadMemberCredentialFromFile()
        {
            throw new NotImplementedException();
        }

        public void SignOutByDeleteToken()
        {
            throw new NotImplementedException();
        }
    }
}
