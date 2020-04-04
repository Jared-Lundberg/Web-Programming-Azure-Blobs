﻿using System;
using BlobCloudStorageAccount=Microsoft.Azure.Storage.CloudStorageAccount;
using TableCloudStorageAccount = Microsoft.Azure.Cosmos.Table.CloudStorageAccount;

namespace Survivor.Services
{
    public class CloudStorageAccountProvider : ICloudStorageAccountProvider
    {
        private string StorageAccountKey => "AccountKey";

        public BlobCloudStorageAccount BlobStorageAccount => BlobCloudStorageAccount.Parse(StorageAccountKey);

        public TableCloudStorageAccount TableStorageAccount => TableCloudStorageAccount.Parse(StorageAccountKey);

    }
}
