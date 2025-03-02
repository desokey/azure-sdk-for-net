// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using System.Xml;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.ProviderHub.Models;

namespace Azure.ResourceManager.ProviderHub
{
    public partial class Sample_DefaultRolloutResource
    {
        // DefaultRollouts_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_DefaultRolloutsGet()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/preview/2021-09-01-preview/examples/DefaultRollouts_Get.json
            // this example is just showing the usage of "DefaultRollouts_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DefaultRolloutResource created on azure
            // for more information of creating DefaultRolloutResource, please refer to the document of DefaultRolloutResource
            string subscriptionId = "ab7a8701-f7ef-471a-a2f4-d0ebbf494f77";
            string providerNamespace = "Microsoft.Contoso";
            string rolloutName = "2020week10";
            ResourceIdentifier defaultRolloutResourceId = DefaultRolloutResource.CreateResourceIdentifier(subscriptionId, providerNamespace, rolloutName);
            DefaultRolloutResource defaultRollout = client.GetDefaultRolloutResource(defaultRolloutResourceId);

            // invoke the operation
            DefaultRolloutResource result = await defaultRollout.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DefaultRolloutData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DefaultRollouts_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DefaultRolloutsDelete()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/preview/2021-09-01-preview/examples/DefaultRollouts_Delete.json
            // this example is just showing the usage of "DefaultRollouts_Delete" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DefaultRolloutResource created on azure
            // for more information of creating DefaultRolloutResource, please refer to the document of DefaultRolloutResource
            string subscriptionId = "ab7a8701-f7ef-471a-a2f4-d0ebbf494f77";
            string providerNamespace = "Microsoft.Contoso";
            string rolloutName = "2020week10";
            ResourceIdentifier defaultRolloutResourceId = DefaultRolloutResource.CreateResourceIdentifier(subscriptionId, providerNamespace, rolloutName);
            DefaultRolloutResource defaultRollout = client.GetDefaultRolloutResource(defaultRolloutResourceId);

            // invoke the operation
            await defaultRollout.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // DefaultRollouts_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_DefaultRolloutsCreateOrUpdate()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/preview/2021-09-01-preview/examples/DefaultRollouts_CreateOrUpdate.json
            // this example is just showing the usage of "DefaultRollouts_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DefaultRolloutResource created on azure
            // for more information of creating DefaultRolloutResource, please refer to the document of DefaultRolloutResource
            string subscriptionId = "ab7a8701-f7ef-471a-a2f4-d0ebbf494f77";
            string providerNamespace = "Microsoft.Contoso";
            string rolloutName = "2020week10";
            ResourceIdentifier defaultRolloutResourceId = DefaultRolloutResource.CreateResourceIdentifier(subscriptionId, providerNamespace, rolloutName);
            DefaultRolloutResource defaultRollout = client.GetDefaultRolloutResource(defaultRolloutResourceId);

            // invoke the operation
            DefaultRolloutData data = new DefaultRolloutData()
            {
                Properties = new DefaultRolloutProperties()
                {
                    Specification = new DefaultRolloutPropertiesSpecification()
                    {
                        ExpeditedRolloutEnabled = true,
                        Canary = new DefaultRolloutSpecificationCanary()
                        {
                            SkipRegions =
{
"eastus2euap"
},
                        },
                        RestOfTheWorldGroupTwo = new DefaultRolloutSpecificationRestOfTheWorldGroupTwo()
                        {
                            WaitDuration = XmlConvert.ToTimeSpan("PT4H"),
                        },
                    },
                },
            };
            ArmOperation<DefaultRolloutResource> lro = await defaultRollout.UpdateAsync(WaitUntil.Completed, data);
            DefaultRolloutResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DefaultRolloutData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DefaultRollouts_Stop
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Stop_DefaultRolloutsStop()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/preview/2021-09-01-preview/examples/DefaultRollouts_Stop.json
            // this example is just showing the usage of "DefaultRollouts_Stop" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DefaultRolloutResource created on azure
            // for more information of creating DefaultRolloutResource, please refer to the document of DefaultRolloutResource
            string subscriptionId = "ab7a8701-f7ef-471a-a2f4-d0ebbf494f77";
            string providerNamespace = "Microsoft.Contoso";
            string rolloutName = "2020week10";
            ResourceIdentifier defaultRolloutResourceId = DefaultRolloutResource.CreateResourceIdentifier(subscriptionId, providerNamespace, rolloutName);
            DefaultRolloutResource defaultRollout = client.GetDefaultRolloutResource(defaultRolloutResourceId);

            // invoke the operation
            await defaultRollout.StopAsync();

            Console.WriteLine($"Succeeded");
        }
    }
}
