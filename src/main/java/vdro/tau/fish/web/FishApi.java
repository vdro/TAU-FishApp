package vdro.tau.fish.web;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.MediaType;
import org.springframework.web.bind.annotation.*;
import vdro.tau.fish.domain.Fish;
import vdro.tau.fish.service.FishImpl;
import com.sun.org.apache.xpath.internal.operations.Bool;

import java.rmi.NoSuchObjectException;
import java.util.Map;


@RestController
public class FishApi {

    @Autowired
    FishImpl fishImpl;

    @RequestMapping("/")
    public String index() {
        return "This is non rest, just checking if everything works.";
    }

    @RequestMapping(value = "/fish/{id}", produces = MediaType.APPLICATION_JSON_VALUE)
    @ResponseBody
    public Fish getProduct(@PathVariable("id") int id) throws  NoSuchObjectException {
        return fishImpl.read(id);

    }

    @RequestMapping(value = "/fish", produces = MediaType.APPLICATION_JSON_VALUE)
    @ResponseBody
    public Map<Integer, Fish> getFish() {
        return fishImpl.readAll();
    }

    @RequestMapping(value = "/fish/add", method = RequestMethod.POST)
    @ResponseBody
    public String createFish(
            @RequestParam(value = "id", required = true) int id,
            @RequestParam(value = "label", required = true) String label,
            @RequestParam(value = "name", required = true) String name,
            @RequestParam(value = "description", required = true) String description,
            @RequestParam(value = "category_id", required = true) int category_id,
            @RequestParam(value = "quantity", required = true) int quantity,
            @RequestParam(value = "net_price", required = true) float net_price,
            @RequestParam(value = "gross_price", required = true) float gross_price,
            @RequestParam(value = "fake_product", required = true) boolean fake_product
    ){

        fishImpl.create(
                new Fish (
                        id,
                        label,
                        name,
                        description,
                        category_id,
                        quantity,
                        net_price,
                        gross_price,
                        fake_product
                )
        );

        return ("Fish with id [" + id + "] has been created in database.");
    }

    @RequestMapping(value = "/fish/update", method = RequestMethod.POST)
    @ResponseBody
    public String updateFish(
            @RequestParam(value = "id", required = true) int id,
            @RequestParam(value = "label", required = false) String _label,
            @RequestParam(value = "name", required = false) String _name,
            @RequestParam(value = "description", required = false) String _description,
            @RequestParam(value = "category_id", required = false) String _category_id,
            @RequestParam(value = "quantity", required = false) String _quantity,
            @RequestParam(value = "net_price", required = false) String _net_price,
            @RequestParam(value = "gross_price", required = false) String _gross_price,
            @RequestParam(value = "fake_product", required = false) String _fake_product
    ) throws NoSuchObjectException {

        Fish FishToUpdate = fishImpl.read(id);

        if(_label != null)
            FishToUpdate.setLabel(_label);
        if(_name != null)
            FishToUpdate.setName(_name);
        if(_description != null)
            FishToUpdate.setDescription(_description);
        if(_category_id != null)
            FishToUpdate.setCategoryId(Integer.parseInt(_category_id));
        if(_quantity != null)
            FishToUpdate.setQuantity(Integer.parseInt(_quantity));
        if(_net_price != null)
            FishToUpdate.setNetPrice(Float.parseFloat(_net_price));
        if(_gross_price != null)
            FishToUpdate.setGrossPrice(Float.parseFloat(_gross_price));
        if(_fake_product != null)
            FishToUpdate.setFakeFish(Boolean.parseBoolean(_fake_product));

        fishImpl.update(FishToUpdate);

        return ("Fish with id [" + id + "] has been created in database.");
    }

    @RequestMapping(value = "/fish/{id}", method = RequestMethod.DELETE, produces = MediaType.TEXT_PLAIN_VALUE)
    @ResponseBody
    public String deleteFish(@PathVariable("id") int id) throws NoSuchObjectException {
        fishImpl.delete(id);
        return new String("Fish with id [" + id + "] has been successufully deleted.");
    }

}
