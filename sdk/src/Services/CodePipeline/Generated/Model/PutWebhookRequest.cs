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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Container for the parameters to the PutWebhook operation.
    /// Defines a webhook and returns a unique webhook URL generated by CodePipeline. This
    /// URL can be supplied to third party source hosting providers to call every time there's
    /// a code change. When CodePipeline receives a POST request on this URL, the pipeline
    /// defined in the webhook is started as long as the POST request satisfied the authentication
    /// and filtering requirements supplied when defining the webhook. RegisterWebhookWithThirdParty
    /// and DeregisterWebhookWithThirdParty APIs can be used to automatically configure supported
    /// third parties to call the generated webhook URL.
    /// </summary>
    public partial class PutWebhookRequest : AmazonCodePipelineRequest
    {
        private WebhookDefinition _webhook;

        /// <summary>
        /// Gets and sets the property Webhook. 
        /// <para>
        /// The detail provided in an input file to create the webhook, such as the webhook name,
        /// the pipeline name, and the action name. Give the webhook a unique name which identifies
        /// the webhook being defined. You may choose to name the webhook after the pipeline and
        /// action it targets so that you can easily recognize what it's used for later.
        /// </para>
        /// </summary>
        public WebhookDefinition Webhook
        {
            get { return this._webhook; }
            set { this._webhook = value; }
        }

        // Check to see if Webhook property is set
        internal bool IsSetWebhook()
        {
            return this._webhook != null;
        }

    }
}