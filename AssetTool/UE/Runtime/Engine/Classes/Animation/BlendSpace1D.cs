namespace AssetTool
{
    [JsonAsset("BlendSpace1D")]
    public class UBlendSpace1D : UBlendSpace
    {
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}