namespace AssetTool
{
    [JsonAsset("ComputeGraph")]
    public class UComputeGraph : UObject
    {
        public List<FComputeKernelResourceSet> KernelResources;

        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref KernelResources);
            return this;
        }
    }

    public class FComputeKernelResourceSet : ITransferable
    {
        public List<FComputeKernelResource> LoadedKernelResources;
        public List<FComputeKernelResource> KernelResourcesByFeatureLevel;

        public ITransferable Move(Transfer transfer)
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

    public class FComputeKernelResource : ITransferable
    {
        public ITransferable Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }
}