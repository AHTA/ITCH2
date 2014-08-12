﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("Model", "FK_dbo_Pages_dbo_UserProfiles_UserProfile_UserId", "UserProfiles", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(ITCH2_1.Models.UserProfiles), "Pages", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(ITCH2_1.Models.Pages), true)]
[assembly: EdmRelationshipAttribute("Model", "PagesCategories", "Categories", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(ITCH2_1.Models.Categories), "Pages", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(ITCH2_1.Models.Pages))]

#endregion

namespace ITCH2_1.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class Entities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new Entities object using the connection string found in the 'Entities' section of the application configuration file.
        /// </summary>
        public Entities() : base("name=Entities", "Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Entities object.
        /// </summary>
        public Entities(string connectionString) : base(connectionString, "Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Entities object.
        /// </summary>
        public Entities(EntityConnection connection) : base(connection, "Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Categories> Categories
        {
            get
            {
                if ((_Categories == null))
                {
                    _Categories = base.CreateObjectSet<Categories>("Categories");
                }
                return _Categories;
            }
        }
        private ObjectSet<Categories> _Categories;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Pages> Pages
        {
            get
            {
                if ((_Pages == null))
                {
                    _Pages = base.CreateObjectSet<Pages>("Pages");
                }
                return _Pages;
            }
        }
        private ObjectSet<Pages> _Pages;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<UserProfiles> UserProfiles
        {
            get
            {
                if ((_UserProfiles == null))
                {
                    _UserProfiles = base.CreateObjectSet<UserProfiles>("UserProfiles");
                }
                return _UserProfiles;
            }
        }
        private ObjectSet<UserProfiles> _UserProfiles;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Categories EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCategories(Categories categories)
        {
            base.AddObject("Categories", categories);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Pages EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPages(Pages pages)
        {
            base.AddObject("Pages", pages);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the UserProfiles EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUserProfiles(UserProfiles userProfiles)
        {
            base.AddObject("UserProfiles", userProfiles);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="Categories")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Categories : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Categories object.
        /// </summary>
        /// <param name="category_id">Initial value of the category_id property.</param>
        public static Categories CreateCategories(global::System.Int32 category_id)
        {
            Categories categories = new Categories();
            categories.category_id = category_id;
            return categories;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 category_id
        {
            get
            {
                return _category_id;
            }
            set
            {
                if (_category_id != value)
                {
                    Oncategory_idChanging(value);
                    ReportPropertyChanging("category_id");
                    _category_id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("category_id");
                    Oncategory_idChanged();
                }
            }
        }
        private global::System.Int32 _category_id;
        partial void Oncategory_idChanging(global::System.Int32 value);
        partial void Oncategory_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String category_name
        {
            get
            {
                return _category_name;
            }
            set
            {
                Oncategory_nameChanging(value);
                ReportPropertyChanging("category_name");
                _category_name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("category_name");
                Oncategory_nameChanged();
            }
        }
        private global::System.String _category_name;
        partial void Oncategory_nameChanging(global::System.String value);
        partial void Oncategory_nameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String category_description
        {
            get
            {
                return _category_description;
            }
            set
            {
                Oncategory_descriptionChanging(value);
                ReportPropertyChanging("category_description");
                _category_description = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("category_description");
                Oncategory_descriptionChanged();
            }
        }
        private global::System.String _category_description;
        partial void Oncategory_descriptionChanging(global::System.String value);
        partial void Oncategory_descriptionChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "PagesCategories", "Pages")]
        public EntityCollection<Pages> Pages
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Pages>("Model.PagesCategories", "Pages");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Pages>("Model.PagesCategories", "Pages", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="Pages")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Pages : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Pages object.
        /// </summary>
        /// <param name="page_id">Initial value of the page_id property.</param>
        /// <param name="page_date">Initial value of the page_date property.</param>
        /// <param name="page_content">Initial value of the page_content property.</param>
        /// <param name="page_description">Initial value of the page_description property.</param>
        /// <param name="page_title">Initial value of the page_title property.</param>
        /// <param name="page_modified">Initial value of the page_modified property.</param>
        /// <param name="page_visible">Initial value of the page_visible property.</param>
        public static Pages CreatePages(global::System.Int32 page_id, global::System.DateTime page_date, global::System.String page_content, global::System.String page_description, global::System.String page_title, global::System.DateTime page_modified, global::System.Boolean page_visible)
        {
            Pages pages = new Pages();
            pages.page_id = page_id;
            pages.page_date = page_date;
            pages.page_content = page_content;
            pages.page_description = page_description;
            pages.page_title = page_title;
            pages.page_modified = page_modified;
            pages.page_visible = page_visible;
            return pages;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 page_id
        {
            get
            {
                return _page_id;
            }
            set
            {
                if (_page_id != value)
                {
                    Onpage_idChanging(value);
                    ReportPropertyChanging("page_id");
                    _page_id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("page_id");
                    Onpage_idChanged();
                }
            }
        }
        private global::System.Int32 _page_id;
        partial void Onpage_idChanging(global::System.Int32 value);
        partial void Onpage_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime page_date
        {
            get
            {
                return _page_date;
            }
            set
            {
                Onpage_dateChanging(value);
                ReportPropertyChanging("page_date");
                _page_date = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("page_date");
                Onpage_dateChanged();
            }
        }
        private global::System.DateTime _page_date;
        partial void Onpage_dateChanging(global::System.DateTime value);
        partial void Onpage_dateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String page_content
        {
            get
            {
                return _page_content;
            }
            set
            {
                Onpage_contentChanging(value);
                ReportPropertyChanging("page_content");
                _page_content = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("page_content");
                Onpage_contentChanged();
            }
        }
        private global::System.String _page_content;
        partial void Onpage_contentChanging(global::System.String value);
        partial void Onpage_contentChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String page_description
        {
            get
            {
                return _page_description;
            }
            set
            {
                Onpage_descriptionChanging(value);
                ReportPropertyChanging("page_description");
                _page_description = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("page_description");
                Onpage_descriptionChanged();
            }
        }
        private global::System.String _page_description;
        partial void Onpage_descriptionChanging(global::System.String value);
        partial void Onpage_descriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String page_title
        {
            get
            {
                return _page_title;
            }
            set
            {
                Onpage_titleChanging(value);
                ReportPropertyChanging("page_title");
                _page_title = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("page_title");
                Onpage_titleChanged();
            }
        }
        private global::System.String _page_title;
        partial void Onpage_titleChanging(global::System.String value);
        partial void Onpage_titleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime page_modified
        {
            get
            {
                return _page_modified;
            }
            set
            {
                Onpage_modifiedChanging(value);
                ReportPropertyChanging("page_modified");
                _page_modified = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("page_modified");
                Onpage_modifiedChanged();
            }
        }
        private global::System.DateTime _page_modified;
        partial void Onpage_modifiedChanging(global::System.DateTime value);
        partial void Onpage_modifiedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean page_visible
        {
            get
            {
                return _page_visible;
            }
            set
            {
                Onpage_visibleChanging(value);
                ReportPropertyChanging("page_visible");
                _page_visible = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("page_visible");
                Onpage_visibleChanged();
            }
        }
        private global::System.Boolean _page_visible;
        partial void Onpage_visibleChanging(global::System.Boolean value);
        partial void Onpage_visibleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String page_image
        {
            get
            {
                return _page_image;
            }
            set
            {
                Onpage_imageChanging(value);
                ReportPropertyChanging("page_image");
                _page_image = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("page_image");
                Onpage_imageChanged();
            }
        }
        private global::System.String _page_image;
        partial void Onpage_imageChanging(global::System.String value);
        partial void Onpage_imageChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> UserProfile_UserId
        {
            get
            {
                return _UserProfile_UserId;
            }
            set
            {
                OnUserProfile_UserIdChanging(value);
                ReportPropertyChanging("UserProfile_UserId");
                _UserProfile_UserId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UserProfile_UserId");
                OnUserProfile_UserIdChanged();
            }
        }
        private Nullable<global::System.Int32> _UserProfile_UserId;
        partial void OnUserProfile_UserIdChanging(Nullable<global::System.Int32> value);
        partial void OnUserProfile_UserIdChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_dbo_Pages_dbo_UserProfiles_UserProfile_UserId", "UserProfiles")]
        public UserProfiles UserProfiles
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<UserProfiles>("Model.FK_dbo_Pages_dbo_UserProfiles_UserProfile_UserId", "UserProfiles").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<UserProfiles>("Model.FK_dbo_Pages_dbo_UserProfiles_UserProfile_UserId", "UserProfiles").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<UserProfiles> UserProfilesReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<UserProfiles>("Model.FK_dbo_Pages_dbo_UserProfiles_UserProfile_UserId", "UserProfiles");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<UserProfiles>("Model.FK_dbo_Pages_dbo_UserProfiles_UserProfile_UserId", "UserProfiles", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "PagesCategories", "Categories")]
        public EntityCollection<Categories> Categories
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Categories>("Model.PagesCategories", "Categories");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Categories>("Model.PagesCategories", "Categories", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="UserProfiles")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class UserProfiles : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new UserProfiles object.
        /// </summary>
        /// <param name="userId">Initial value of the UserId property.</param>
        public static UserProfiles CreateUserProfiles(global::System.Int32 userId)
        {
            UserProfiles userProfiles = new UserProfiles();
            userProfiles.UserId = userId;
            return userProfiles;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                if (_UserId != value)
                {
                    OnUserIdChanging(value);
                    ReportPropertyChanging("UserId");
                    _UserId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("UserId");
                    OnUserIdChanged();
                }
            }
        }
        private global::System.Int32 _UserId;
        partial void OnUserIdChanging(global::System.Int32 value);
        partial void OnUserIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                OnUserNameChanging(value);
                ReportPropertyChanging("UserName");
                _UserName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("UserName");
                OnUserNameChanged();
            }
        }
        private global::System.String _UserName;
        partial void OnUserNameChanging(global::System.String value);
        partial void OnUserNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Email
        {
            get
            {
                return _Email;
            }
            set
            {
                OnEmailChanging(value);
                ReportPropertyChanging("Email");
                _Email = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Email");
                OnEmailChanged();
            }
        }
        private global::System.String _Email;
        partial void OnEmailChanging(global::System.String value);
        partial void OnEmailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String PublicUserName
        {
            get
            {
                return _PublicUserName;
            }
            set
            {
                OnPublicUserNameChanging(value);
                ReportPropertyChanging("PublicUserName");
                _PublicUserName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("PublicUserName");
                OnPublicUserNameChanged();
            }
        }
        private global::System.String _PublicUserName;
        partial void OnPublicUserNameChanging(global::System.String value);
        partial void OnPublicUserNameChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_dbo_Pages_dbo_UserProfiles_UserProfile_UserId", "Pages")]
        public EntityCollection<Pages> Pages
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Pages>("Model.FK_dbo_Pages_dbo_UserProfiles_UserProfile_UserId", "Pages");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Pages>("Model.FK_dbo_Pages_dbo_UserProfiles_UserProfile_UserId", "Pages", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}