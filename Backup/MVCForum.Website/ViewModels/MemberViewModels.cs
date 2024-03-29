﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using DataAnnotationsExtensions;
using MVCForum.Domain.DomainModel;
using MVCForum.Website.Application;
using MVCForum.Website.Areas.Admin.ViewModels;

namespace MVCForum.Website.ViewModels
{
    public class ActiveMembersViewModel
    {
        public IList<MembershipUser> ActiveMembers { get; set; } 
    }

    public class MemberAddViewModel
    {
        [Required]
        [ForumMvcResourceDisplayName("Members.Label.Username")]
        [StringLength(150, MinimumLength = 4)]
        public string UserName { get; set; }

        [Required]
        [Email]
        [ForumMvcResourceDisplayName("Members.Label.EmailAddress")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        [DataType(DataType.Password)]
        [ForumMvcResourceDisplayName("Members.Label.Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password")]
        [ForumMvcResourceDisplayName("Members.Label.ConfirmPassword")]
        public string ConfirmPassword { get; set; }

        [Required]
        public int MinPasswordLength { get; set; }

        [ForumMvcResourceDisplayName("Members.Label.UserIsApproved")]
        public bool IsApproved { get; set; }

        [ForumMvcResourceDisplayName("Members.Label.Comment")]
        public string Comment { get; set; }

        [ForumMvcResourceDisplayName("Members.Label.Roles")]
        public string[] Roles { get; set; }

        public IList<MembershipRole> AllRoles { get; set; }

        public string SpamAnswer { get; set; }

        public string ReturnUrl { get; set; }
    }

    public class MemberFrontEndEditViewModel
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [ForumMvcResourceDisplayName("Members.Label.Username")]
        [StringLength(150, MinimumLength = 4)]
        public string UserName { get; set; }

        [ForumMvcResourceDisplayName("Members.Label.EmailAddress")]
        [Email]
        [Required]
        public string Email { get; set; }

        [ForumMvcResourceDisplayName("Members.Label.Signature")]
        [StringLength(1000)]
        //[UIHint("bbeditor"), AllowHtml]
        //[UIHint("tinymceeditor"), AllowHtml]
        [UIHint("markdowneditor"), AllowHtml]
        public string Signature { get; set; }

        [ForumMvcResourceDisplayName("Members.Label.Age")]
        [Numeric]
        public int? Age { get; set; }

        [ForumMvcResourceDisplayName("Members.Label.Location")]
        [StringLength(100)]
        public string Location { get; set; }

        [ForumMvcResourceDisplayName("Members.Label.Website")]
        [Url]
        [StringLength(100)]
        public string Website { get; set; }

        [ForumMvcResourceDisplayName("Members.Label.Twitter")]
        [Url]
        [StringLength(60)]
        public string Twitter { get; set; }

        [ForumMvcResourceDisplayName("Members.Label.Facebook")]
        [Url]
        [StringLength(60)]
        public string Facebook { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [ForumMvcResourceDisplayName("Members.Label.Username")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [ForumMvcResourceDisplayName("Members.Label.EmailAddress")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        [DataType(DataType.Password)]
        [ForumMvcResourceDisplayName("Members.Label.Password ")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password")]
        [ForumMvcResourceDisplayName("Members.Label.ConfirmPassword")]
        public string ConfirmPassword { get; set; }

        [Required]
        public bool LogInNow { get; set; }

        [Required]
        public int MinPasswordLength { get; set; }
    }

    public class LogOnViewModel
    {
        public string ReturnUrl { get; set; }

        [Required]
        [ForumMvcResourceDisplayName("Members.Label.Username")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [ForumMvcResourceDisplayName("Members.Label.Password")]
        public string Password { get; set; }

        [ForumMvcResourceDisplayName("Members.Label.RememberMe")]
        public bool RememberMe { get; set; }
    }

    public class ViewMemberViewModel
    {
        public MembershipUser User { get; set; }
        public Guid LoggedOnUserId { get; set; }
    }

    public class ViewMemberDiscussionsViewModel
    {
        public IList<Topic> Topics { get; set; }
        public Dictionary<Category, PermissionSet> AllPermissionSets { get; set; }
        public MembershipUser CurrentUser { get; set; }
    }

    public class ViewAdminSidePanelViewModel
    {
        public MembershipUser CurrentUser { get; set; }
        public int NewPrivateMessageCount { get; set; }
    }

    public class AdminMemberProfileToolsViewModel
    {
        public MembershipUser CurrentUser { get; set; }
    }

    public class AutocompleteViewModel
    {
        public string label { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class ReportMemberViewModel
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Reason { get; set; }
    }

    public class ListLatestMembersViewModel
    {
        public Dictionary<string, string> Users { get; set; }
    }

    public class PublicMemberListViewModel
    {
        [ForumMvcResourceDisplayName("Members.Label.Users")]
        public IList<PublicSingleMemberListViewModel> Users { get; set; }
        public int? PageIndex { get; set; }
        public int? TotalCount { get; set; }
        public string Search { get; set; }
    }

    public class PublicSingleMemberListViewModel
    {
        [ForumMvcResourceDisplayName("Members.Label.Username")]
        public string UserName { get; set; }

        public string NiceUrl { get; set; }

        [ForumMvcResourceDisplayName("Members.Label.DateJoined")]
        public DateTime CreateDate { get; set; }

        public int TotalPoints { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [ForumMvcResourceDisplayName("Members.Label.EmailAddressBlank")]
        [Email]
        [Required]
        public string EmailAddress { get; set; }
    }

    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [ForumMvcResourceDisplayName("Members.Label.CurrentPassword")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        [DataType(DataType.Password)]
        [ForumMvcResourceDisplayName("Members.Label.NewPassword")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [ForumMvcResourceDisplayName("Members.Label.ConfirmNewPassword")]
        [Compare("NewPassword")]
        public string ConfirmPassword { get; set; }
    }
}