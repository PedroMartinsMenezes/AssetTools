namespace AssetTool
{
    [JsonAsset("WebAPIOperationParameter")]
    public class UWebAPIOperationParameter : UWebAPIProperty
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WebAPIOperationRequest")]
    public class UWebAPIOperationRequest : UWebAPIModel
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WebAPIOperationResponse")]
    public class UWebAPIOperationResponse : UWebAPIModel
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WebAPIOperationError")]
    public class UWebAPIOperationError : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WebAPIOperation")]
    public class UWebAPIOperation : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}