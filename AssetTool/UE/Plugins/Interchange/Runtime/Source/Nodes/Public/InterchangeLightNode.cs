namespace AssetTool
{
    [JsonAsset("InterchangeBaseLightNode")]
    public class UInterchangeBaseLightNode : UInterchangeBaseNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeLightNode")]
    public class UInterchangeLightNode : UInterchangeBaseLightNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangePointLightNode")]
    public class UInterchangePointLightNode : UInterchangeLightNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeSpotLightNode")]
    public class UInterchangeSpotLightNode : UInterchangePointLightNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeRectLightNode")]
    public class UInterchangeRectLightNode : UInterchangeLightNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeDirectionalLightNode")]
    public class UInterchangeDirectionalLightNode : UInterchangeBaseLightNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}