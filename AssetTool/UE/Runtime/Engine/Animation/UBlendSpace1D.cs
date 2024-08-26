namespace AssetTool
{
    [JsonAsset]
    public class UBlendSpace1D : UBlendSpace
    {
        public new const string TypeName = "BlendSpace1D";

        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}