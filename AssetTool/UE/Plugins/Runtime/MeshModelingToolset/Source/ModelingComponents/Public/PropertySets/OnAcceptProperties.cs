namespace AssetTool
{
    [JsonAsset("OnAcceptHandleSourcesPropertiesBase")]
    public class UOnAcceptHandleSourcesPropertiesBase : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OnAcceptHandleSourcesProperties")]
    public class UOnAcceptHandleSourcesProperties : UOnAcceptHandleSourcesPropertiesBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OnAcceptHandleSourcesPropertiesSingle")]
    public class UOnAcceptHandleSourcesPropertiesSingle : UOnAcceptHandleSourcesPropertiesBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}