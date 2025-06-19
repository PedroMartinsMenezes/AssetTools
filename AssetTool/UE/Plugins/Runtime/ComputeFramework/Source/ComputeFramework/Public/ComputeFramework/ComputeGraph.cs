namespace AssetTool
{
    [JsonAsset("ComputeGraph")]
    public class UComputeGraph : UObject
    {
        public List<FComputeKernelResourceSet> KernelResources;

        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref KernelResources);
            return this;
        }
    }

    public class FComputeKernelResourceSet : ITransferible
    {
        public List<FComputeKernelResource> LoadedKernelResources;
        public List<FComputeKernelResource> KernelResourcesByFeatureLevel;

        public ITransferible Move(Transfer transfer)
        {
            bool HasEditorData = !transfer.GlobalObjects.IsFilterEditorOnly();
            if (HasEditorData)
            {
                transfer.Move(ref LoadedKernelResources);
            }
            else
            {
                transfer.Move(ref KernelResourcesByFeatureLevel);
            }
            return this;
        }
    }

    public class FComputeKernelResource : ITransferible
    {
        public ITransferible Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }
}