// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The gallery artifact version source.
    /// </summary>
    public partial class GalleryArtifactVersionSource
    {
        /// <summary>
        /// Initializes a new instance of the GalleryArtifactVersionSource
        /// class.
        /// </summary>
        public GalleryArtifactVersionSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GalleryArtifactVersionSource
        /// class.
        /// </summary>
        /// <param name="id">The id of the gallery artifact version source. Can
        /// specify a disk uri, snapshot uri, user image or storage account
        /// resource.</param>
        public GalleryArtifactVersionSource(string id = default(string))
        {
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the id of the gallery artifact version source. Can
        /// specify a disk uri, snapshot uri, user image or storage account
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

    }
}
