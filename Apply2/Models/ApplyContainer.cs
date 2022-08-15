using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.ComponentModel;

namespace Apply2.Models
{
    public enum GenderEnum
    {
        [Display(Name = "男")]
        Male,
        [Display(Name = "女")]
        Female
    }
    public class ApplyContainer
    {

        [Newtonsoft.Json.JsonIgnore]
        public int Id { get; set; }

        [Display(Name = "姓名")]
        [Required(ErrorMessage = "申请人姓名不能为空")]
        [MaxLength(10, ErrorMessage = "最大长度小于10个字符")]
        public string Name { get; set; }

        [Display(Name = "性别")]
        [Required(ErrorMessage = "申请人性别不能为空")]
        public GenderEnum Gender { get; set; }

        [Display(Name = "出生日期")]
        [Required(ErrorMessage = "申请人出生日期不能为空")]
        public DateTime Birth { get; set; }

        [Display(Name = "电话")]
        [StringLength(11,ErrorMessage = "请填写正确的手机号")]
        [Required(ErrorMessage = "申请人电话不能为空")]
        public string Tel { get; set; }

        [Display(Name = "邮箱")]
        public string Mail { get; set; }

        [Display(Name = "所在地")]
        [Required(ErrorMessage = "申请人所在地不能为空")]
        public string Location { get; set; }

        [Display(Name = "期望试用开始时间")]
        [Required(ErrorMessage = "期望试用开始时间不能为空")]
        //[JsonConverter(typeof(DateTimeConverter), "yyyy-MM")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM}")]
        public DateTime Strail { get; set; }

        [Display(Name = "期望试用结束时间")]
        [Required(ErrorMessage = "期望试用结束时间不能为空")]
        public DateTime Etrail { get; set; }
    }
}
