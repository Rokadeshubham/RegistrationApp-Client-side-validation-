﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrationApp.Models
{
    public class PartialClasses
    {
        [MetadataType(typeof(UserMetadata))]
        public partial class User
        {

        }
    }
}