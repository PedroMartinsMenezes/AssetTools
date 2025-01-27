namespace AssetTool
{
    [JsonAsset("InterchangeBaseLightFactoryNode")]
    public class UInterchangeBaseLightFactoryNode : UInterchangeActorFactoryNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeDirectionalLightFactoryNode")]
    public class UInterchangeDirectionalLightFactoryNode : UInterchangeBaseLightFactoryNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeLightFactoryNode")]
    public class UInterchangeLightFactoryNode : UInterchangeBaseLightFactoryNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeRectLightFactoryNode")]
    public class UInterchangeRectLightFactoryNode : UInterchangeLightFactoryNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangePointLightFactoryNode")]
    public class UInterchangePointLightFactoryNode : UInterchangeLightFactoryNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeSpotLightFactoryNode")]
    public class UInterchangeSpotLightFactoryNode : UInterchangePointLightFactoryNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}