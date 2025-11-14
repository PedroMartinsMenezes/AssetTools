namespace AssetTool
{
    [JsonAsset("InputAction")]
    public class UInputAction : UDataAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}