using System.Text;
using Content.Client.Message;
using Content.Shared.PlantAnalyzer;

using Content.Shared.Temperature;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.CustomControls;
using Robust.Client.UserInterface.XAML;
using Robust.Shared.Prototypes;
using Robust.Client.GameObjects;
using Robust.Client.ResourceManagement;
using Content.Shared.IdentityManagement;

namespace Content.Client.PlantAnalyzer.UI
{
    [GenerateTypedNameReferences]
    public sealed partial class PlantAnalyzerWindow : DefaultWindow
    {
        private readonly IEntityManager _entityManager;
        private readonly SpriteSystem _spriteSystem;
        private readonly IPrototypeManager _prototypes;
        private readonly IResourceCache _cache;

        public PlantAnalyzerWindow()
        {
            RobustXamlLoader.Load(this);

            var dependencies = IoCManager.Instance!;
            _entityManager = dependencies.Resolve<IEntityManager>();
            _spriteSystem = _entityManager.System<SpriteSystem>();
            _prototypes = dependencies.Resolve<IPrototypeManager>();
            _cache = dependencies.Resolve<IResourceCache>();

        }
        public void Populate(PlantAnalyzerScannedSeedPlantInformation msg)
        {
            GroupsContainer.RemoveAllChildren();

            var target = _entityManager.GetEntity(msg.TargetEntity);

            if (target == null)
            {
                NoData.Visible = true;
                return;
            }

            NoData.Visible = false;

            string entityName = Loc.GetString("health-analyzer-window-entity-unknown-text");
            if (_entityManager.HasComponent<MetaDataComponent>(target.Value))
            {
                entityName = Identity.Name(target.Value, _entityManager);
            }

            PlantName.Text = Loc.GetString(
                "health-analyzer-window-entity-health-text",
                ("entityName", entityName)
            );


        }
    }
}
