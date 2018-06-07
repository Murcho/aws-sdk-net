/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the clouddirectory-2016-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Container for the parameters to the ListIndex operation.
    /// Lists objects attached to the specified index.
    /// </summary>
    public partial class ListIndexRequest : AmazonCloudDirectoryRequest
    {
        private ConsistencyLevel _consistencyLevel;
        private string _directoryArn;
        private ObjectReference _indexReference;
        private int? _maxResults;
        private string _nextToken;
        private List<ObjectAttributeRange> _rangesOnIndexedValues = new List<ObjectAttributeRange>();

        /// <summary>
        /// Gets and sets the property ConsistencyLevel. 
        /// <para>
        /// The consistency level to execute the request at.
        /// </para>
        /// </summary>
        public ConsistencyLevel ConsistencyLevel
        {
            get { return this._consistencyLevel; }
            set { this._consistencyLevel = value; }
        }

        // Check to see if ConsistencyLevel property is set
        internal bool IsSetConsistencyLevel()
        {
            return this._consistencyLevel != null;
        }

        /// <summary>
        /// Gets and sets the property DirectoryArn. 
        /// <para>
        /// The ARN of the directory that the index exists in.
        /// </para>
        /// </summary>
        public string DirectoryArn
        {
            get { return this._directoryArn; }
            set { this._directoryArn = value; }
        }

        // Check to see if DirectoryArn property is set
        internal bool IsSetDirectoryArn()
        {
            return this._directoryArn != null;
        }

        /// <summary>
        /// Gets and sets the property IndexReference. 
        /// <para>
        /// The reference to the index to list.
        /// </para>
        /// </summary>
        public ObjectReference IndexReference
        {
            get { return this._indexReference; }
            set { this._indexReference = value; }
        }

        // Check to see if IndexReference property is set
        internal bool IsSetIndexReference()
        {
            return this._indexReference != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of objects in a single page to retrieve from the index during a
        /// request. For more information, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/limits.html#limits_cd">AWS
        /// Directory Service Limits</a>.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property RangesOnIndexedValues. 
        /// <para>
        /// Specifies the ranges of indexed values that you want to query.
        /// </para>
        /// </summary>
        public List<ObjectAttributeRange> RangesOnIndexedValues
        {
            get { return this._rangesOnIndexedValues; }
            set { this._rangesOnIndexedValues = value; }
        }

        // Check to see if RangesOnIndexedValues property is set
        internal bool IsSetRangesOnIndexedValues()
        {
            return this._rangesOnIndexedValues != null && this._rangesOnIndexedValues.Count > 0; 
        }

    }
}