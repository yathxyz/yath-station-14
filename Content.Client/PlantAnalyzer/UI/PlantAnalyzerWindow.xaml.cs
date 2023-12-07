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
using Content.Server.Botany.Components;

using System.Linq;
using System.Numerics;

using Robust.Client.Graphics;
using Robust.Client.UserInterface.Controls;

using Robust.Shared.Utility;

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
        public void UpdateState(PlantAnalyzerScannedSeedPlantInformation msg)
        {



            var target = _entityManager.GetEntity(msg.TargetEntity);
            var text = new StringBuilder();

            if (msg.TargetEntity != null && _entityManager.TryGetComponent<PlantAnalyzerComponent>(target, out var plantanalyzer))
            {

            }
            /*
            PlantName = Loc.GetString(("plant-analyzer-window-label-name-scanned-plant")) + " " + Loc.GetString(msg.SeedName);

            PlantHP.SetMarkup($"\n{Loc.GetString($"plant-analyzer-plant-endurance-text", ("seedEndurance", msg.SeedEndurance))}");
            text.Append($"{Loc.GetString($"plant-analyzer-plant-yield-text", ("seedYield", msg.SeedYield))}");
            text.Append($"\n{Loc.GetString($"plant-analyzer-plant-potency-text", ("seedPotency", msg.SeedPotency))}");
            text.Append($"\n{Loc.GetString($"plant-analyzer-plant-harvest-text", ("seedHarvest", msg.SeedHarvestType))}\n");
            Diagnostics.Text = text.ToString();

            Chemistry.SetMarkup($"{Loc.GetString($"plant-analyzer-plant-chemistry-text", ("seedChemistry", msg.SeedChem))}");
            var seedMinC = Math.Round(TemperatureHelpers.KelvinToCelsius(msg.SeedMinTemp), 1).ToString();
            var seedMaxC = Math.Round(TemperatureHelpers.KelvinToCelsius(msg.SeedMaxTemp), 1).ToString();
            Temperature.SetMarkup($"{Loc.GetString($"plant-analyzer-plant-temp-comfort-text", ("seedMin", Math.Round(msg.SeedMinTemp)), ("seedMax", Math.Round(msg.SeedMaxTemp)), ("seedMinC", seedMinC), ("seedMaxC", seedMaxC))}");
            TraitsName.SetMarkup($"{Loc.GetString($"plant-analyzer-plant-mutations-text") + " " + (msg.SeedMut)}\n");

            if (msg.IsTray)
            {
                PlantTray.Text = $"{Loc.GetString($"plant-analyzer-plant-holder")}";
                HealthName.SetMarkup($"\n{Loc.GetString($"plant-analyzer-plant-holder-health", ("seedHealth", msg.SeedHealth))}");
                ProblemsName.SetMarkup($"{Loc.GetString($"plant-analyzer-plant-holder-problems") + " " + (msg.SeedProblems)}");
            }
            */
        }
    }
}
