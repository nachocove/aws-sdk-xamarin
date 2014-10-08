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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */

using System;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Configuration for accessing Amazon DescribeAdjustmentTypes service
    /// </summary>
    public partial class DescribeAdjustmentTypesResponse : DescribeAdjustmentTypesResult
    {
        /// <summary>
        /// Gets and sets the DescribeAdjustmentTypesResult property.
        /// Represents the output of a DescribeAdjustmentTypes operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the DescribeAdjustmentTypesResult class are now available on the DescribeAdjustmentTypesResponse class. You should use the properties on DescribeAdjustmentTypesResponse instead of accessing them through DescribeAdjustmentTypesResult.")]
        public DescribeAdjustmentTypesResult DescribeAdjustmentTypesResult
        {
            get
            {
                return this;
            }
        }
    }
}