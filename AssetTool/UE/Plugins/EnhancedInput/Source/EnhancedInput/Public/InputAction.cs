namespace AssetTool
{
    [JsonAsset("InputAction")]
    public class UInputAction : UDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}