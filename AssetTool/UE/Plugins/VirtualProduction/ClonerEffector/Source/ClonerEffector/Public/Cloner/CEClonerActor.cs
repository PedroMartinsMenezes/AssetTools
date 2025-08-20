namespace AssetTool
{
    [JsonAsset("CEClonerComponent")]
    public class UCEClonerComponent : UNiagaraComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
