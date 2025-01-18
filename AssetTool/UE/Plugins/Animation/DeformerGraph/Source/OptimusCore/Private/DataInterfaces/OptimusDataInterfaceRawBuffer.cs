namespace AssetTool
{
    [JsonAsset("OptimusRawBufferDataInterface")]
    public class UOptimusRawBufferDataInterface : UOptimusComputeDataInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusTransientBufferDataInterface")]
    public class UOptimusTransientBufferDataInterface : UOptimusRawBufferDataInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusPersistentBufferDataInterface")]
    public class UOptimusPersistentBufferDataInterface : UOptimusRawBufferDataInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusRawBufferDataProvider")]
    public class UOptimusRawBufferDataProvider : UComputeDataProvider
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusTransientBufferDataProvider")]
    public class UOptimusTransientBufferDataProvider : UOptimusRawBufferDataProvider
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusPersistentBufferDataProvider")]
    public class UOptimusPersistentBufferDataProvider : UOptimusRawBufferDataProvider
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}