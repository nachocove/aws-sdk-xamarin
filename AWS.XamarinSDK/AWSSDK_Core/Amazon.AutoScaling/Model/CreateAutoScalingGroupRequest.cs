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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAutoScalingGroup operation.
    /// Creates a new Auto Scaling group with the specified name and other attributes. When
    /// the creation request is completed, the Auto Scaling group is ready to be used in other
    /// calls.
    /// </summary>
    public partial class CreateAutoScalingGroupRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private List<string> _availabilityZones = new List<string>();
        private int? _defaultCooldown;
        private int? _desiredCapacity;
        private int? _healthCheckGracePeriod;
        private string _healthCheckType;
        private string _instanceId;
        private string _launchConfigurationName;
        private List<string> _loadBalancerNames = new List<string>();
        private int? _maxSize;
        private int? _minSize;
        private string _placementGroup;
        private List<Tag> _tags = new List<Tag>();
        private List<string> _terminationPolicies = new List<string>();
        private string _vPCZoneIdentifier;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        ///  The name of the Auto Scaling group. 
        /// </para>
        /// </summary>
        public string AutoScalingGroupName
        {
            get { return this._autoScalingGroupName; }
            set { this._autoScalingGroupName = value; }
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this._autoScalingGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        ///  A list of Availability Zones for the Auto Scaling group. This is required unless
        /// you have specified subnets. 
        /// </para>
        /// </summary>
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && this._availabilityZones.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DefaultCooldown. 
        /// <para>
        ///  The amount of time, in seconds, between a successful scaling activity and the succeeding
        /// scaling activity.
        /// </para>
        ///  
        /// <para>
        /// If a <code>DefaultCooldown</code> period is not specified, Auto Scaling uses the default
        /// value of 300 as the default cool down period for the Auto Scaling group. For more
        /// information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AS_Concepts.html#Cooldown">Cooldown
        /// Period</a> 
        /// </para>
        /// </summary>
        public int DefaultCooldown
        {
            get { return this._defaultCooldown.GetValueOrDefault(); }
            set { this._defaultCooldown = value; }
        }

        // Check to see if DefaultCooldown property is set
        internal bool IsSetDefaultCooldown()
        {
            return this._defaultCooldown.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DesiredCapacity. 
        /// <para>
        ///  The number of Amazon EC2 instances that should be running in the group. The desired
        /// capacity must be greater than or equal to the minimum size and less than or equal
        /// to the maximum size specified for the Auto Scaling group. 
        /// </para>
        /// </summary>
        public int DesiredCapacity
        {
            get { return this._desiredCapacity.GetValueOrDefault(); }
            set { this._desiredCapacity = value; }
        }

        // Check to see if DesiredCapacity property is set
        internal bool IsSetDesiredCapacity()
        {
            return this._desiredCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HealthCheckGracePeriod. 
        /// <para>
        /// Length of time in seconds after a new Amazon EC2 instance comes into service that
        /// Auto Scaling starts checking its health. During this time any health check failure
        /// for the that instance is ignored.
        /// </para>
        ///  
        /// <para>
        /// This is required if you are adding <code>ELB</code> health check. Frequently, new
        /// instances need to warm up, briefly, before they can pass a health check. To provide
        /// ample warm-up time, set the health check grace period of the group to match the expected
        /// startup period of your application.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/as-add-elb-healthcheck.html#as-add-elb-healthcheck-api">Add
        /// an Elastic Load Balancing Health Check</a>.
        /// </para>
        /// </summary>
        public int HealthCheckGracePeriod
        {
            get { return this._healthCheckGracePeriod.GetValueOrDefault(); }
            set { this._healthCheckGracePeriod = value; }
        }

        // Check to see if HealthCheckGracePeriod property is set
        internal bool IsSetHealthCheckGracePeriod()
        {
            return this._healthCheckGracePeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HealthCheckType. 
        /// <para>
        /// The service you want the health checks from, Amazon EC2 or Elastic Load Balancer.
        /// Valid values are <code>EC2</code> or <code>ELB</code>.
        /// </para>
        ///  
        /// <para>
        /// By default, the Auto Scaling health check uses the results of Amazon EC2 instance
        /// status checks to determine the health of an instance. For more information, see <a
        /// href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AS_Concepts.html#healthcheck">Health
        /// Check</a>.
        /// </para>
        /// </summary>
        public string HealthCheckType
        {
            get { return this._healthCheckType; }
            set { this._healthCheckType = value; }
        }

        // Check to see if HealthCheckType property is set
        internal bool IsSetHealthCheckType()
        {
            return this._healthCheckType != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        ///  The ID of the Amazon EC2 instance you want to use to create the Auto Scaling group.
        /// Use this attribute if you want to create an Auto Scaling group using an EC2 instance
        /// instead of a launch configuration. 
        /// </para>
        ///  
        /// <para>
        ///  When you use an instance to create an Auto Scaling group, a new launch configuration
        /// is first created and then associated with the Auto Scaling group. The new launch configuration
        /// derives all its attributes from the instance that is used to create the Auto Scaling
        /// group, with the exception of <code>BlockDeviceMapping</code>. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/create-asg-from-instance.html">Create
        /// an Auto Scaling Group Using EC2 Instance</a> in the <i>Auto Scaling Developer Guide</i>.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchConfigurationName. 
        /// <para>
        ///  The name of an existing launch configuration to use to launch new instances. Use
        /// this attribute if you want to create an Auto Scaling group using an existing launch
        /// configuration instead of an EC2 instance. 
        /// </para>
        /// </summary>
        public string LaunchConfigurationName
        {
            get { return this._launchConfigurationName; }
            set { this._launchConfigurationName = value; }
        }

        // Check to see if LaunchConfigurationName property is set
        internal bool IsSetLaunchConfigurationName()
        {
            return this._launchConfigurationName != null;
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerNames. 
        /// <para>
        ///  A list of existing Elastic Load Balancing load balancers to use. The load balancers
        /// must be associated with the AWS account. 
        /// </para>
        ///  
        /// <para>
        /// For information on using load balancers, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/US_SetUpASLBApp.html">Load
        /// Balance Your Auto Scaling Group</a> in the <i>Auto Scaling Developer Guide</i>.
        /// </para>
        /// </summary>
        public List<string> LoadBalancerNames
        {
            get { return this._loadBalancerNames; }
            set { this._loadBalancerNames = value; }
        }

        // Check to see if LoadBalancerNames property is set
        internal bool IsSetLoadBalancerNames()
        {
            return this._loadBalancerNames != null && this._loadBalancerNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxSize. 
        /// <para>
        ///  The maximum size of the Auto Scaling group. 
        /// </para>
        /// </summary>
        public int MaxSize
        {
            get { return this._maxSize.GetValueOrDefault(); }
            set { this._maxSize = value; }
        }

        // Check to see if MaxSize property is set
        internal bool IsSetMaxSize()
        {
            return this._maxSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinSize. 
        /// <para>
        ///  The minimum size of the Auto Scaling group. 
        /// </para>
        /// </summary>
        public int MinSize
        {
            get { return this._minSize.GetValueOrDefault(); }
            set { this._minSize = value; }
        }

        // Check to see if MinSize property is set
        internal bool IsSetMinSize()
        {
            return this._minSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PlacementGroup. 
        /// <para>
        /// Physical location of an existing cluster placement group into which you want to launch
        /// your instances. For information about cluster placement group, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cluster_computing.html">Using
        /// Cluster Instances</a>
        /// </para>
        /// </summary>
        public string PlacementGroup
        {
            get { return this._placementGroup; }
            set { this._placementGroup = value; }
        }

        // Check to see if PlacementGroup property is set
        internal bool IsSetPlacementGroup()
        {
            return this._placementGroup != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  The tag to be created or updated. Each tag should be defined by its resource type,
        /// resource ID, key, value, and a propagate flag. Valid values: key=<i>value</i>, value=<i>value</i>,
        /// propagate=<i>true</i> or <i>false</i>. Value and propagate are optional parameters.
        /// </para>
        ///  
        /// <para>
        /// For information about using tags, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/ASTagging.html">Tag
        /// Your Auto Scaling Groups and Amazon EC2 Instances</a> in the <i>Auto Scaling Developer
        /// Guide</i>. 
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TerminationPolicies. 
        /// <para>
        /// A standalone termination policy or a list of termination policies used to select the
        /// instance to terminate. The policies are executed in the order that they are listed.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  For more information on configuring a termination policy for your Auto Scaling group,
        /// see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/us-termination-policy.html">Instance
        /// Termination Policy for Your Auto Scaling Group</a> in the <i>Auto Scaling Developer
        /// Guide</i>. 
        /// </para>
        /// </summary>
        public List<string> TerminationPolicies
        {
            get { return this._terminationPolicies; }
            set { this._terminationPolicies = value; }
        }

        // Check to see if TerminationPolicies property is set
        internal bool IsSetTerminationPolicies()
        {
            return this._terminationPolicies != null && this._terminationPolicies.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VPCZoneIdentifier. 
        /// <para>
        /// A comma-separated list of subnet identifiers of Amazon Virtual Private Clouds (Amazon
        /// VPCs).
        /// </para>
        ///  
        /// <para>
        /// If you specify subnets and Availability Zones with this call, ensure that the subnets'
        /// Availability Zones match the Availability Zones specified. 
        /// </para>
        ///  
        /// <para>
        /// For information on launching your Auto Scaling group into Amazon VPC subnets, see
        /// <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/autoscalingsubnets.html">Auto
        /// Scaling in Amazon Virtual Private Cloud</a> in the <i>Auto Scaling Developer Guide</i>
        /// .
        /// </para>
        /// </summary>
        public string VPCZoneIdentifier
        {
            get { return this._vPCZoneIdentifier; }
            set { this._vPCZoneIdentifier = value; }
        }

        // Check to see if VPCZoneIdentifier property is set
        internal bool IsSetVPCZoneIdentifier()
        {
            return this._vPCZoneIdentifier != null;
        }

    }
}