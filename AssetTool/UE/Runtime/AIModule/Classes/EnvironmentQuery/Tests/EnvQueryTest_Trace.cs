namespace AssetTool
{
    [JsonAsset("EnvQueryTest_Trace")]
    public class UEnvQueryTest_Trace : UEnvQueryTest
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}