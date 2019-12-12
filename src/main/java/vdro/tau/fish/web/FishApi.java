package vdro.tau.fish.web;

import vdro.tau.fish.domain.Fish;
import vdro.tau.fish.service.FishDao;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.MediaType;
import org.springframework.web.bind.annotation.*;

import java.sql.SQLException;
import java.util.LinkedList;
import java.util.List;


@RestController
public class FishApi {

    private FishDao fishDao;

    @Autowired
    public FishApi(FishDao fishDao) {
        this.fishDao = fishDao;
    }

    @RequestMapping("/")
    public String index() {
        return "This is non rest, just checking if everything works.";
    }

    @RequestMapping(value = "/fish/{id}", produces = MediaType.APPLICATION_JSON_VALUE)
    @ResponseBody
    public Fish getFish (@PathVariable("id") int id) throws SQLException {
        return fishDao.get(id);
    }

    @RequestMapping(value = "/fish", produces = MediaType.APPLICATION_JSON_VALUE)
    @ResponseBody
    public List<Fish> getFish() {
        return fishDao.getAll();
    }

    @RequestMapping(value = "/fish/add", method = RequestMethod.POST)
    @ResponseBody
    public String createFish(
            @RequestParam(value = "label", required = true) String label,
            @RequestParam(value = "name", required = true) String name,
            @RequestParam(value = "description", required = true) String description,
            @RequestParam(value = "category_id", required = true) int category_id,
            @RequestParam(value = "quantity", required = true) int quantity,
            @RequestParam(value = "net_price", required = true) float net_price,
            @RequestParam(value = "gross_price", required = true) float gross_price,
            @RequestParam(value = "fake_fish", required = true) boolean fake_fish
    ){

        Fish p = new Fish ();
        p.setLabel(label);
        p.setName(name);
        p.setDescription(description);
        p.setCategoryId(category_id);
        p.setQuantity(quantity);
        p.setNetPrice(net_price);
        p.setGrossPrice(gross_price);
        p.setFakeFish(fake_fish);

        fishDao.create(p);

        return ("Fish has been successfully created in database.");
    }

    @RequestMapping(value = "/fish/update", method = RequestMethod.POST)
    @ResponseBody
    public String updateFish(
            @RequestParam(value = "id", required = true) String _id,
            @RequestParam(value = "label", required = false) String _label,
            @RequestParam(value = "name", required = false) String _name,
            @RequestParam(value = "description", required = false) String _description,
            @RequestParam(value = "category_id", required = false) String _category_id,
            @RequestParam(value = "quantity", required = false) String _quantity,
            @RequestParam(value = "net_price", required = false) String _net_price,
            @RequestParam(value = "gross_price", required = false) String _gross_price,
            @RequestParam(value = "fake_fish", required = false) String _fake_fish
    ) throws SQLException {

        Fish fishToUpdate = fishDao.get(Integer.parseInt(_id));

        if(_label != null)
            fishToUpdate.setLabel(_label);
        if(_name != null)
            fishToUpdate.setName(_name);
        if(_description != null)
            fishToUpdate.setDescription(_description);
        if(_category_id != null)
            fishToUpdate.setCategoryId(Integer.parseInt(_category_id));
        if(_quantity != null)
            fishToUpdate.setQuantity(Integer.parseInt(_quantity));
        if(_net_price != null)
            fishToUpdate.setNetPrice(Float.parseFloat(_net_price));
        if(_gross_price != null)
            fishToUpdate.setGrossPrice(Float.parseFloat(_gross_price));
        if(_fake_fish != null)
            fishToUpdate.setFakeFish(Boolean.parseBoolean(_fake_fish));

        fishDao.update(fishToUpdate);

        return ("Fish with id [" + _id + "] has been updated in database.");
    }

    @RequestMapping(value = "/fish/delete/{id}", method = RequestMethod.DELETE, produces = MediaType.TEXT_PLAIN_VALUE)
    @ResponseBody
    public String deleteFish(@PathVariable("id") long id) throws SQLException {
        fishDao.delete(id);
        return new String("Fish with id [" + id + "] has been successufully deleted.");
    }

}
