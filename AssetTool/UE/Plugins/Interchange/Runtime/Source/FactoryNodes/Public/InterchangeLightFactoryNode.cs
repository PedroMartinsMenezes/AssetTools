namespace AssetTool
{
    [JsonAsset("InterchangeBaseLightFactoryNode")]
    public class UInterchangeBaseLightFactoryNode : UInterchangeActorFactoryNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeDirectionalLightFactoryNode")]
    public class UInterchangeDirectionalLightFactoryNode : UInterchangeBaseLightFactoryNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeLightFactoryNode")]
    public class UInterchangeLightFactoryNode : UInterchangeBaseLightFactoryNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeRectLightFactoryNode")]
    public class UInterchangeRectLightFactoryNode : UInterchangeLightFactoryNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangePointLightFactoryNode")]
    public class UInterchangePointLightFactoryNode : UInterchangeLightFactoryNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeSpotLightFactoryNode")]
    public class UInterchangeSpotLightFactoryNode : UInterchangePointLightFactoryNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}