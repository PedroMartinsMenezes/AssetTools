namespace AssetTool
{
    [JsonAsset("AvaMaskMaterialFactoryBase")]
    public class UAvaMaskMaterialFactoryBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AvaMaskMaterialFactory")]
    public class UAvaMaskMaterialFactory : UAvaMaskMaterialFactoryBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AvaMaskMaterialInstanceConstantFactory")]
    public class UAvaMaskMaterialInstanceConstantFactory : UAvaMaskMaterialFactoryBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AvaMaskMaterialInstanceDynamicFactory")]
    public class UAvaMaskMaterialInstanceDynamicFactory : UAvaMaskMaterialFactoryBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AvaMaskDesignedMaterialFactory")]
    public class UAvaMaskDesignedMaterialFactory : UAvaMaskMaterialFactoryBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}