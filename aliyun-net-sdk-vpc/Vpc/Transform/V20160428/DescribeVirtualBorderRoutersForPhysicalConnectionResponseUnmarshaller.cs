/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeVirtualBorderRoutersForPhysicalConnectionResponseUnmarshaller
    {
        public static DescribeVirtualBorderRoutersForPhysicalConnectionResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVirtualBorderRoutersForPhysicalConnectionResponse describeVirtualBorderRoutersForPhysicalConnectionResponse = new DescribeVirtualBorderRoutersForPhysicalConnectionResponse();

			describeVirtualBorderRoutersForPhysicalConnectionResponse.HttpResponse = context.HttpResponse;
			describeVirtualBorderRoutersForPhysicalConnectionResponse.RequestId = context.StringValue("DescribeVirtualBorderRoutersForPhysicalConnection.RequestId");
			describeVirtualBorderRoutersForPhysicalConnectionResponse.PageNumber = context.IntegerValue("DescribeVirtualBorderRoutersForPhysicalConnection.PageNumber");
			describeVirtualBorderRoutersForPhysicalConnectionResponse.PageSize = context.IntegerValue("DescribeVirtualBorderRoutersForPhysicalConnection.PageSize");
			describeVirtualBorderRoutersForPhysicalConnectionResponse.TotalCount = context.IntegerValue("DescribeVirtualBorderRoutersForPhysicalConnection.TotalCount");

			List<DescribeVirtualBorderRoutersForPhysicalConnectionResponse.DescribeVirtualBorderRoutersForPhysicalConnection_VirtualBorderRouterForPhysicalConnectionType> describeVirtualBorderRoutersForPhysicalConnectionResponse_virtualBorderRouterForPhysicalConnectionSet = new List<DescribeVirtualBorderRoutersForPhysicalConnectionResponse.DescribeVirtualBorderRoutersForPhysicalConnection_VirtualBorderRouterForPhysicalConnectionType>();
			for (int i = 0; i < context.Length("DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet.Length"); i++) {
				DescribeVirtualBorderRoutersForPhysicalConnectionResponse.DescribeVirtualBorderRoutersForPhysicalConnection_VirtualBorderRouterForPhysicalConnectionType virtualBorderRouterForPhysicalConnectionType = new DescribeVirtualBorderRoutersForPhysicalConnectionResponse.DescribeVirtualBorderRoutersForPhysicalConnection_VirtualBorderRouterForPhysicalConnectionType();
				virtualBorderRouterForPhysicalConnectionType.VbrId = context.StringValue("DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet["+ i +"].VbrId");
				virtualBorderRouterForPhysicalConnectionType.VbrOwnerUid = context.LongValue("DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet["+ i +"].VbrOwnerUid");
				virtualBorderRouterForPhysicalConnectionType.EccId = context.StringValue("DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet["+ i +"].EccId");
				virtualBorderRouterForPhysicalConnectionType.Type = context.StringValue("DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet["+ i +"].Type");
				virtualBorderRouterForPhysicalConnectionType.CreationTime = context.StringValue("DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet["+ i +"].CreationTime");
				virtualBorderRouterForPhysicalConnectionType.ActivationTime = context.StringValue("DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet["+ i +"].ActivationTime");
				virtualBorderRouterForPhysicalConnectionType.TerminationTime = context.StringValue("DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet["+ i +"].TerminationTime");
				virtualBorderRouterForPhysicalConnectionType.RecoveryTime = context.StringValue("DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet["+ i +"].RecoveryTime");
				virtualBorderRouterForPhysicalConnectionType.VlanId = context.IntegerValue("DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet["+ i +"].VlanId");
				virtualBorderRouterForPhysicalConnectionType.Status = context.StringValue("DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet["+ i +"].Status");
				virtualBorderRouterForPhysicalConnectionType.CircuitCode = context.StringValue("DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet["+ i +"].CircuitCode");
				virtualBorderRouterForPhysicalConnectionType.LocalGatewayIp = context.StringValue("DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet["+ i +"].LocalGatewayIp");
				virtualBorderRouterForPhysicalConnectionType.PeerGatewayIp = context.StringValue("DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet["+ i +"].PeerGatewayIp");
				virtualBorderRouterForPhysicalConnectionType.PeeringSubnetMask = context.StringValue("DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet["+ i +"].PeeringSubnetMask");
				virtualBorderRouterForPhysicalConnectionType.PConnVbrChargeType = context.StringValue("DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet["+ i +"].PConnVbrChargeType");
				virtualBorderRouterForPhysicalConnectionType.PConnVbrExpireTime = context.StringValue("DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet["+ i +"].PConnVbrExpireTime");
				virtualBorderRouterForPhysicalConnectionType.PConnVbrBussinessStatus = context.StringValue("DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet["+ i +"].PConnVbrBussinessStatus");
				virtualBorderRouterForPhysicalConnectionType.Bandwidth = context.StringValue("DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet["+ i +"].Bandwidth");
				virtualBorderRouterForPhysicalConnectionType.LocalIpv6GatewayIp = context.StringValue("DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet["+ i +"].LocalIpv6GatewayIp");
				virtualBorderRouterForPhysicalConnectionType.PeerIpv6GatewayIp = context.StringValue("DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet["+ i +"].PeerIpv6GatewayIp");
				virtualBorderRouterForPhysicalConnectionType.PeeringIpv6SubnetMask = context.StringValue("DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet["+ i +"].PeeringIpv6SubnetMask");
				virtualBorderRouterForPhysicalConnectionType.EnableIpv6 = context.BooleanValue("DescribeVirtualBorderRoutersForPhysicalConnection.VirtualBorderRouterForPhysicalConnectionSet["+ i +"].EnableIpv6");

				describeVirtualBorderRoutersForPhysicalConnectionResponse_virtualBorderRouterForPhysicalConnectionSet.Add(virtualBorderRouterForPhysicalConnectionType);
			}
			describeVirtualBorderRoutersForPhysicalConnectionResponse.VirtualBorderRouterForPhysicalConnectionSet = describeVirtualBorderRoutersForPhysicalConnectionResponse_virtualBorderRouterForPhysicalConnectionSet;
        
			return describeVirtualBorderRoutersForPhysicalConnectionResponse;
        }
    }
}
