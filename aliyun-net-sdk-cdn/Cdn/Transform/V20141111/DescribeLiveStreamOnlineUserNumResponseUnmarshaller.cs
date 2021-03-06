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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Cdn.Model.V20141111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeLiveStreamOnlineUserNumResponseUnmarshaller
    {
        public static DescribeLiveStreamOnlineUserNumResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveStreamOnlineUserNumResponse describeLiveStreamOnlineUserNumResponse = new DescribeLiveStreamOnlineUserNumResponse();

			describeLiveStreamOnlineUserNumResponse.HttpResponse = context.HttpResponse;
			describeLiveStreamOnlineUserNumResponse.RequestId = context.StringValue("DescribeLiveStreamOnlineUserNum.RequestId");
			describeLiveStreamOnlineUserNumResponse.TotalUserNumber = context.LongValue("DescribeLiveStreamOnlineUserNum.TotalUserNumber");

			List<DescribeLiveStreamOnlineUserNumResponse.LiveStreamOnlineUserNumInfo> onlineUserInfo = new List<DescribeLiveStreamOnlineUserNumResponse.LiveStreamOnlineUserNumInfo>();
			for (int i = 0; i < context.Length("DescribeLiveStreamOnlineUserNum.OnlineUserInfo.Length"); i++) {
				DescribeLiveStreamOnlineUserNumResponse.LiveStreamOnlineUserNumInfo liveStreamOnlineUserNumInfo = new DescribeLiveStreamOnlineUserNumResponse.LiveStreamOnlineUserNumInfo();
				liveStreamOnlineUserNumInfo.StreamUrl = context.StringValue("DescribeLiveStreamOnlineUserNum.OnlineUserInfo["+ i +"].StreamUrl");
				liveStreamOnlineUserNumInfo.UserNumber = context.LongValue("DescribeLiveStreamOnlineUserNum.OnlineUserInfo["+ i +"].UserNumber");

				onlineUserInfo.Add(liveStreamOnlineUserNumInfo);
			}
			describeLiveStreamOnlineUserNumResponse.OnlineUserInfo = onlineUserInfo;
        
			return describeLiveStreamOnlineUserNumResponse;
        }
    }
}