//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

using System;
using System.Linq;

using Rock.Attribute;
using Rock.Data;
using Rock.ViewModel;
using Rock.Web.Cache;

namespace Rock.Model
{
    /// <summary>
    /// ExceptionLog Service class
    /// </summary>
    public partial class ExceptionLogService : Service<ExceptionLog>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionLogService"/> class
        /// </summary>
        /// <param name="context">The context.</param>
        public ExceptionLogService(RockContext context) : base(context)
        {
        }

        /// <summary>
        /// Determines whether this instance can delete the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <returns>
        ///   <c>true</c> if this instance can delete the specified item; otherwise, <c>false</c>.
        /// </returns>
        public bool CanDelete( ExceptionLog item, out string errorMessage )
        {
            errorMessage = string.Empty;
            return true;
        }
    }

    /// <summary>
    /// ExceptionLog View Model Helper
    /// </summary>
    [DefaultViewModelHelper( typeof( ExceptionLog ) )]
    public partial class ExceptionLogViewModelHelper : ViewModelHelper<ExceptionLog, Rock.ViewModel.ExceptionLogViewModel>
    {
        /// <summary>
        /// Converts the model to a view model.
        /// </summary>
        /// <param name="model">The entity.</param>
        /// <param name="currentPerson">The current person.</param>
        /// <param name="loadAttributes">if set to <c>true</c> [load attributes].</param>
        /// <returns></returns>
        public override Rock.ViewModel.ExceptionLogViewModel CreateViewModel( ExceptionLog model, Person currentPerson = null, bool loadAttributes = true )
        {
            if ( model == null )
            {
                return default;
            }

            var viewModel = new Rock.ViewModel.ExceptionLogViewModel
            {
                Id = model.Id,
                Guid = model.Guid,
                Cookies = model.Cookies,
                Description = model.Description,
                ExceptionType = model.ExceptionType,
                Form = model.Form,
                HasInnerException = model.HasInnerException,
                PageId = model.PageId,
                PageUrl = model.PageUrl,
                ParentId = model.ParentId,
                QueryString = model.QueryString,
                ServerVariables = model.ServerVariables,
                SiteId = model.SiteId,
                Source = model.Source,
                StackTrace = model.StackTrace,
                StatusCode = model.StatusCode,
                CreatedDateTime = model.CreatedDateTime,
                ModifiedDateTime = model.ModifiedDateTime,
                CreatedByPersonAliasId = model.CreatedByPersonAliasId,
                ModifiedByPersonAliasId = model.ModifiedByPersonAliasId,
            };

            AddAttributesToViewModel( model, viewModel, currentPerson, loadAttributes );
            ApplyAdditionalPropertiesAndSecurityToViewModel( model, viewModel, currentPerson, loadAttributes );
            return viewModel;
        }
    }


    /// <summary>
    /// Generated Extension Methods
    /// </summary>
    public static partial class ExceptionLogExtensionMethods
    {
        /// <summary>
        /// Clones this ExceptionLog object to a new ExceptionLog object
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="deepCopy">if set to <c>true</c> a deep copy is made. If false, only the basic entity properties are copied.</param>
        /// <returns></returns>
        public static ExceptionLog Clone( this ExceptionLog source, bool deepCopy )
        {
            if (deepCopy)
            {
                return source.Clone() as ExceptionLog;
            }
            else
            {
                var target = new ExceptionLog();
                target.CopyPropertiesFrom( source );
                return target;
            }
        }

        /// <summary>
        /// Clones this ExceptionLog object to a new ExceptionLog object with default values for the properties in the Entity and Model base classes.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static ExceptionLog CloneWithoutIdentity( this ExceptionLog source )
        {
            var target = new ExceptionLog();
            target.CopyPropertiesFrom( source );

            target.Id = 0;
            target.Guid = Guid.NewGuid();
            target.ForeignKey = null;
            target.ForeignId = null;
            target.ForeignGuid = null;
            target.CreatedByPersonAliasId = null;
            target.CreatedDateTime = RockDateTime.Now;
            target.ModifiedByPersonAliasId = null;
            target.ModifiedDateTime = RockDateTime.Now;

            return target;
        }

        /// <summary>
        /// Copies the properties from another ExceptionLog object to this ExceptionLog object
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="source">The source.</param>
        public static void CopyPropertiesFrom( this ExceptionLog target, ExceptionLog source )
        {
            target.Id = source.Id;
            target.Cookies = source.Cookies;
            target.Description = source.Description;
            target.ExceptionType = source.ExceptionType;
            target.ForeignGuid = source.ForeignGuid;
            target.ForeignKey = source.ForeignKey;
            target.Form = source.Form;
            target.HasInnerException = source.HasInnerException;
            target.PageId = source.PageId;
            target.PageUrl = source.PageUrl;
            target.ParentId = source.ParentId;
            target.QueryString = source.QueryString;
            target.ServerVariables = source.ServerVariables;
            target.SiteId = source.SiteId;
            target.Source = source.Source;
            target.StackTrace = source.StackTrace;
            target.StatusCode = source.StatusCode;
            target.CreatedDateTime = source.CreatedDateTime;
            target.ModifiedDateTime = source.ModifiedDateTime;
            target.CreatedByPersonAliasId = source.CreatedByPersonAliasId;
            target.ModifiedByPersonAliasId = source.ModifiedByPersonAliasId;
            target.Guid = source.Guid;
            target.ForeignId = source.ForeignId;

        }

        /// <summary>
        /// Creates a view model from this entity
        /// </summary>
        /// <param name="model">The entity.</param>
        /// <param name="currentPerson" >The currentPerson.</param>
        /// <param name="loadAttributes" >Load attributes?</param>
        public static Rock.ViewModel.ExceptionLogViewModel ToViewModel( this ExceptionLog model, Person currentPerson = null, bool loadAttributes = false )
        {
            var helper = new ExceptionLogViewModelHelper();
            var viewModel = helper.CreateViewModel( model, currentPerson, loadAttributes );
            return viewModel;
        }

    }

}