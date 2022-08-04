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
//

import { ListItemBag } from "@Obsidian/ViewModels/Utility/listItemBag";

/**
 * Contains the details about a single content collection item that can
 * be picked by the individual in the custom settings for the Content
 * Collection View block. This extends the standard ListItemBag to include
 * the filters that are available to be used with this content collection.
 */
export type ContentCollectionListItemBag = {
    /** Gets or sets the filters that are available to this content collection. */
    filters?: ListItemBag[] | null;

    /** Gets or sets the value. */
    value?: string | null;

    /** Gets or sets the text. */
    text?: string | null;

    /** Gets or sets the category for this item. */
    category?: string | null;
};