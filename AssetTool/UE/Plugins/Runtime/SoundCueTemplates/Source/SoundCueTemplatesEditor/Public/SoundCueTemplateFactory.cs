namespace AssetTool
{
    [JsonAsset("SoundCueTemplateCopyFactory")]
    public class USoundCueTemplateCopyFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SoundCueTemplateFactory")]
    public class USoundCueTemplateFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SoundCueTemplateClassTemplate")]
    public class USoundCueTemplateClassTemplate : UPluginClassTemplate
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}