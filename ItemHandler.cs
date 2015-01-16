using LeagueSharp;
using LeagueSharp.Common;
using MAC.Model;
using MAC.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp.Common.Items;

namespace MAC.Controller
{
    internal class ItemHandler : Utilitario
    {

        private Menu _menu;

        // Itens Ofensivos
        public Items.Item ruinedKing = new Item(3153, 450f);
        public Items.Item bilgewater = new Item(3144, 450f);
        public Items.Item youmuuGhost = new Item(3142, 0f);
        public Items.Item hydra = new Item(3074, 400f);
        public Items.Item tiamat = new Item(3077, 400f);
        public Items.Item hextech = new Item(3146, 700f);

        private const int ruinedKingi = 3153;
        private const int bilgewateri = 3144;
        private const int youmuuGhosti = 3142;
        private const int hydrai = 3074;
        private const int tiamati = 3077;
        private const int hextechi = 3146;

        private float botrkrange = 450f;
        private float bilgerange = 450f;
        private float youmuurange = 0f;
        private float hydrarange = 400f;
        private float tiamatrange = 400f;
        private float hextechrange = 700f;

        // Itens Defensivos
        public Items.Item zhonya = new Item(3157, 0f);
        public Items.Item randuin = new Item(3143, 500f);

        private const int zhonyaID = 3157;
        private const int randuinID = 3143;

        /*

        public override void Load(Menu config)
        {
            config.AddItem(new MenuItem("itemActive", "Use Items").SetValue(true));
            config.AddItem(new MenuItem("reidestruido", "Use Botrk").SetValue(true));
            config.AddItem(new MenuItem("formuladorei", "Use Bilgewater").SetValue(true));
            config.AddItem(new MenuItem("ghostyoumuu", "Use Youmuu's Ghost").SetValue(true));
            config.AddItem(new MenuItem("hydrazinha", "Use Hydra").SetValue(true));
            config.AddItem(new MenuItem("tiamatinho", "Use Tiamat").SetValue(true));
            config.AddItem(new MenuItem("hextechs", "Use Hextech").SetValue(true));

            _menu = config;

            Game.OnGameUpdate += GameOnOnGameUpdate;
        }

        */

        private static int bortkID()
        {
            return ruinedKingi;
        }

        private static int bilgewaterID()
        {
            return bilgewateri;
        }

        private static int youmuuGhostID()
        {
            return youmuuGhosti;
        }

        private static int hydraID()
        {
            return hydrai;
        }

        private static int tiamatID()
        {
            return tiamati;
        }
        private static int hextechID()
        {
            return hextechi;
        }

    }
}
