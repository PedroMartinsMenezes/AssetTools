namespace AssetTool
{
    [JsonAsset("InputMappingContext_Factory")]
    public class UInputMappingContext_Factory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InputAction_Factory")]
    public class UInputAction_Factory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}