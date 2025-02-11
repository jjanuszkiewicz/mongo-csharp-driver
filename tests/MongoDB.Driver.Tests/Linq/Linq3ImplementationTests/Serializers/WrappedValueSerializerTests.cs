﻿/* Copyright 2010-present MongoDB Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using FluentAssertions;
using MongoDB.Bson.Serialization;
using MongoDB.Driver.Linq.Linq3Implementation.Serializers;
using Moq;
using Xunit;

namespace MongoDB.Driver.Tests.Linq.Linq3ImplementationTests.Serializers
{
    public class WrappedValueSerializerTests
    {
        [Fact]
        public void constructor_should_initialize_instance()
        {
            var valueSerializer = Mock.Of<IBsonSerializer<int>>();

            var subject = new WrappedValueSerializer<int>("_v", valueSerializer);

            subject.FieldName.Should().Be("_v");
            subject.ValueSerializer.Should().BeSameAs(valueSerializer);
            subject.ValueType.Should().BeSameAs(typeof(int));
        }
    }
}
