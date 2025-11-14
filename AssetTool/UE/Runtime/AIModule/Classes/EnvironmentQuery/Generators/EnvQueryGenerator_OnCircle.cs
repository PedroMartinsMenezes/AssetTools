namespace AssetTool
{
    [JsonAsset("EnvQueryGenerator_OnCircle")]
    public class UEnvQueryGenerator_OnCircle : UEnvQueryGenerator_ProjectedPoints
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}